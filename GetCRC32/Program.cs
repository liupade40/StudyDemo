using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCRC32
{
    class Program
    {
        static void Main(string[] args)
        {
            CRC32Cls CRC = new CRC32Cls();
            
        }
    }
    class CRC32Cls
    {
        protected int[] Crc32Table;
        //生成CRC32码表
        public void GetCRC32Table()
        {
            int Crc;
            Crc32Table = new int[256];
            int i, j;
            for (i = 0; i < 256; i++)
            {
                Crc = (int)i;
                for (j = 8; j > 0; j--)
                {
                    if ((Crc & 1) == 1)
                        Crc = (Crc >> 1);
                    else
                        Crc >>= 1;
                }
                Crc32Table[i] = Crc;
            }
        }

        //获取字符串的CRC32校验值
        public int GetCRC32Str(string sInputString)
        {
            //生成码表
            GetCRC32Table();
            byte[] buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(sInputString);
            int value = 0;
            int len = buffer.Length;
            for (int i = 0; i < len; i++)
            {
                value = (value >> 8) ^ Crc32Table[(value & 0xFF) ^ buffer[i]];
            }
            return value;
        }
    }
}
