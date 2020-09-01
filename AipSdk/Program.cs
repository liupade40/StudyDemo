using System;
using Baidu.Aip.Ocr;
using System.IO;

namespace AipSdkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Baidu.Aip.Ocr.Ocr("Api Key", "Secret Key");
          //  var image = File.ReadAllBytes(@"D:\用户目录\Documents\Visual Studio 2015\Projects\Demo\AipSdk\TIM截图20171023094133.png");

            // 网图识别
         //   var result = client.WebImage(image, null);
            //Console.WriteLine(result);
        }
    }
}
