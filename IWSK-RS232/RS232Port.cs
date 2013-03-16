using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace IWSK_RS232
{
    class RS232Port 
    {
        private SerialPort serialPort;

        public bool IsOpen
        {
            get { return serialPort != null && serialPort.IsOpen; }
        }
    }
}
