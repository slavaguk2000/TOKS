using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    class HamingCoder
    {
        MainForm form;
        Random random;
        public HamingCoder(MainForm form)
        {
            this.form = form;
            random = new Random();
        }
        private string byteToString(byte[] byteArray)
        {
            string strinFromBytes = "";
            for (int i = 0; i < byteArray.Length; i++)
                strinFromBytes += (char)byteArray[i];
            return strinFromBytes;
        }

        private byte[] stringToByte(string sourceString)
        {
            byte[] byteArray = new byte[sourceString.Length];
            for (int i = 0; i < sourceString.Length; i++)
                byteArray[i] = (byte)sourceString[i];
            return byteArray;
        }

        private bool isEven(int i, BitArray newBitMessage)
        {
            int count = 0;
            int N = (int)Math.Pow(2, i - 1);
            for (int j = N - 1; j < newBitMessage.Length; j += 2 * N)
            {
                for (int k = 0; k < N && j + k < newBitMessage.Length; k++)
                {
                    if (newBitMessage[j + k])
                        count++;
                }
            }
            return count % 2 != 0;
        }

        private void initHammingFormatArray(ref BitArray source, ref BitArray distanition)
        {
            for (int i = 0, j = 0; i < distanition.Length; i++, j++)
            {
                if (Math.Pow(2, (int)Math.Log(i + 1, 2)) == i + 1)
                {
                    j--;
                    continue;
                }
                distanition[i] = source[j];
            }
        }
        public string coder(string message, bool createError)
        {
            BitArray bitMessage = new BitArray(stringToByte(message));
            BitArray newBitMessage = new BitArray(bitMessage.Length);
            initHammingFormatArray(ref bitMessage, ref newBitMessage);
            for (int i = 1; i <= Math.Log(newBitMessage.Length, 2) + 1; i++)
                bitMessage[8*8 + i- 1] = isEven(i, newBitMessage);
                //bitMessage[(int)Math.Pow(2, i - 1) - 1] = isEven(i, newBitMessage);
            if (createError) 
            { 
                int num = random.Next(bitMessage.Length);
                bitMessage[num] = !bitMessage[num];
            }
            byte[] array = new byte[message.Length];
            bitMessage.CopyTo(array, 0);
            return byteToString(array);
        }

        public string decoder(string message)
        {
            int error = 0;
            BitArray bitMessage = new BitArray(stringToByte(message));
            BitArray newBitMessage = new BitArray(bitMessage.Length);
            for (int i = 1; i <= Math.Log(newBitMessage.Length, 2) + 1; i++)
            {
                newBitMessage[(int)Math.Pow(2, i - 1) - 1] = bitMessage[8 * 8 + i - 1];
                bitMessage[8 * 8 + i - 1] = false;
            }
            initHammingFormatArray(ref bitMessage, ref newBitMessage);
            for (int i = 1; i <= Math.Log(newBitMessage.Length, 2) + 1; i++)
                if(isEven(i,newBitMessage)) error += (int)Math.Pow(2, i - 1);
            if (error > 0)
            {
                form.addControlDebugString("Message was got with error in bit with number: " + error);
                error--;
                if (error < newBitMessage.Length)
                {
                    form.addControlDebugString("Message was corrected");
                    newBitMessage[error] = !newBitMessage[error];
                }
            }
            BitArray endBitMessage = new BitArray(newBitMessage.Length);
            for (int i = 0, j = 0; i < newBitMessage.Length; i++, j++)
            {
                if (Math.Pow(2, (int)Math.Log(i + 1, 2)) == i + 1)
                {
                    j--;
                    continue;
                }
                endBitMessage[j] = newBitMessage[i];
            }            
            byte[] array = new byte[message.Length];
            endBitMessage.CopyTo(array, 0);
            return byteToString(array);
        }
    }
}
