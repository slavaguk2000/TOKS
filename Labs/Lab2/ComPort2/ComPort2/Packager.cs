using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    public class Packager
    {
        public const char flag = (char)10;
        private const char ESC = (char)125;
        private const char ESCChange = (char)93;
        private const char flagChange = (char)94;
        private const byte headerSize = 3;
        private const byte trailerSize = 1;
        private const byte dataSize = 5;
        public const byte packageSize = headerSize + trailerSize + dataSize;

        public char distanitionAddress { get; set; }
        public char sourceAddress { get; set; }
        public bool error { get; set; }

        public Packager(byte distanitionAddress, byte sourceAddress, bool error)
        {
            this.distanitionAddress = (char)distanitionAddress;
            this.sourceAddress = (char)sourceAddress;
            this.error = error;
        }

        public string package(string data)
        {
            if (data.Length > dataSize) throw new Exception("Too large data");
            string message = "";
            message += flag;
            message += distanitionAddress;
            message += sourceAddress;
            message += data;
            for (int i = data.Length; i < dataSize; i++)
                message += '\0';
            message += (char)(error ? 1 : 0);
            return message;
        }

        public string unpackage(string message)
        {
            if (message.Length != packageSize || message[0] != flag) throw new FormatException("Invalid message");
            if (message[1] != sourceAddress) throw new Exception("Invalid address");
            if (message[headerSize + dataSize] == 1) throw new InvalidProgramException("Error message");
            return message.Substring(headerSize, dataSize);
        }

        public string byteStaffing(string message)
        {
            string staffMessage = "";
            if (message.Length != packageSize || message[0] != flag) throw new Exception("Invalid message");
            staffMessage += flag;
            foreach (byte symbol in message.Substring(1))
            {
                if (symbol == flag)
                {
                    staffMessage += ESC;
                    staffMessage += flagChange;
                }
                else staffMessage += symbol;
                if (symbol == ESC) staffMessage += ESCChange;
            }
            return staffMessage;
        }

        public string unByteStaffing(string staffMessage)
        {
            string message = "";
            if (staffMessage.Length < packageSize || staffMessage[0] != flag) throw new FormatException("Invalid message");
            message += flag;
            bool esc = false;
            foreach (char symbol in staffMessage.Substring(1))
            {
                if (esc)
                {
                    switch (symbol)
                    {
                        case flagChange:
                            message += flag;
                            break;
                        case ESCChange:
                            message += ESC;
                            break;
                        default:
                            throw new Exception("Invalid staffing");
                    }
                    esc = false;
                }
                else if (symbol == ESC)
                    esc = true;
                else message += symbol;
            }
            return message;
        }
    }
}
