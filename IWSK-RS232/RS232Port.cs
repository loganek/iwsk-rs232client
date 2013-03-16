using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;

namespace IWSK_RS232
{
    class SentEventArgs : EventArgs
    {
        private byte[] buffer;

        public byte[] Buff
        {
            get { return buffer; }
        }

        public SentEventArgs(byte[] buff)
        {
            if (buff == null)
                buffer = null;
            else
            {
                buffer = new byte[buff.Length];
                Buffer.BlockCopy(buff, 0, buffer, 0, buffer.Length);
            }
        }
    }

    delegate void DataSentEventHandler(object sender, SentEventArgs e);

    class RS232Port 
    {
        private SerialPort serialPort;
        private string portName;
        private int baudRate;
        private Parity parity;
        private StopBits stopBits;
        private int dataBits;
        private static Parity[] parityArray = { Parity.None, Parity.Even, Parity.Odd/*, Parity.Mark, Parity.Space*/ };
        private static StopBits[] stopBitsArray = { StopBits.One, /*StopBits.OnePointFive,*/ StopBits.Two };
        private List<byte> readBytes = new List<byte>();

        public void SetConnectionParameters(string portName, int baudRate, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.None)
        {
            this.portName = portName;
            this.baudRate = baudRate;
            this.parity = parity;
            this.dataBits = dataBits;
            this.stopBits = stopBits;
        }

        public bool Connect()
        {
            if(serialPort != null)
                serialPort.Dispose();   // cannot wait for a garbage collector

            serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
            serialPort.DataReceived += port_DataReceived;

            if (serialPort.IsOpen)
                return true;

            try
            {
                serialPort.Open();

                if (!serialPort.IsOpen)
                    return false;

                OnConnected(EventArgs.Empty);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool Disconnect()
        {
            if (!serialPort.IsOpen)
                return true;

            try
            {
                serialPort.Close();
                serialPort.DataReceived -= port_DataReceived;   // because of memory leaks
            }
            catch (IOException ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }

            OnDisconnected(EventArgs.Empty);

            return true;
        }

        public bool Send(byte[] buf)
        {
            if (buf == null)
                return true;

            try
            {
                serialPort.Write(buf, 0, buf.Length);
                OnDataSent(new SentEventArgs(buf));
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false; 
            }
        }

        public void port_DataReceived(object sender, EventArgs e)
        {
            int toRead = serialPort.BytesToRead;
            byte[] buffer = new byte[toRead];

            serialPort.Read(buffer, 0, toRead);
            readBytes.AddRange(buffer);

            OnDataReceived(EventArgs.Empty);
        }

        public List<byte> GetReadBytes()
        {
            List<byte> newList = new List<byte>(readBytes);

            readBytes.Clear();

            return newList;
        }

        public bool IsOpen
        {
            get { return serialPort != null && serialPort.IsOpen; }
        }

        public string ErrorMessage
        {
            get;
            private set;
        }

        public static Parity ParityArray(int index)
        {
            return parityArray[index];
        }

        public static StopBits StopBitsArray(int index)
        {
            return stopBitsArray[index];
        }


#region events
        public event EventHandler Connected;
        public event EventHandler Disconnected;
        public event EventHandler DataReceived;
        public event DataSentEventHandler DataSent;

        protected virtual void OnConnected(EventArgs e)
        {
            if (Connected != null)
                Connected(this, e);
        }

        protected virtual void OnDisconnected(EventArgs e)
        {
            if (Disconnected != null)
                Disconnected(this, e);
        }

        protected virtual void OnDataReceived(EventArgs e)
        {
            if (DataReceived != null)
                DataReceived(this, e);
        }

        protected virtual void OnDataSent(SentEventArgs e)
        {
            if (DataSent != null)
                DataSent(this, e);
        }
#endregion
    }
}
