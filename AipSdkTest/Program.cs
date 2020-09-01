using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AipSdkTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new Baidu.Aip.Ocr.Ocr("ClKHixnqs0HsEFQ5vsdqfQgH", "gSsGt3IGQMGCWzKnkLucejOcXGxIuV5H");
            var image = File.ReadAllBytes(@"D:\Project\AipSdkTest\TIM截图20171023094133.png");

            // 网图识别
            var result = client.BankCard(image, null);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
