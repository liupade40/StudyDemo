using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            Analysis("您尾号9042的信用卡13日12:59消费人民币29.00元。★快抽iPhone 7！→ cmbt.cn/RMm 。[招商银行]");
            Analysis("【广发银行】您尾号9095广发卡12日20:35消费人民币4.00元，交易商户:财付通。");
            Analysis("您尾号9768交行信用卡27日13时30分成功消费人民币14.89元，当前可用额度为人民币12.97元。【交通银行】");
            Analysis("尾号6520的账户，于01月05日 11:37向刘彬成功转出2,600.00元，具体入账情况请至收款行查询。【网商银行】");
            Analysis("您尾号9893的卡片18年01月17日21:27于财付通消费人民币288.00元。本卡人民币可用额度27.56元。-中信信用卡");
            Analysis("【民生银行】您信用卡4126于21日9:25消费人民币3950.00元，回复FQZY4126123950.00立即办理12期自由分期，分期1万元每天手续费低至2.3元。立即报名享全国3000+商户支付最高减100。详询回C29");
            Analysis("【华夏信用卡】您尾号9775的华夏信用卡于17:11消费人民币688.00元，欲查询可用余额，请回复YE9775。");
            Console.ReadKey();
        }

        private static void Analysis(string content)
        {
            if ((content.Contains("尾号") || content.Contains("信用卡")) && content.Contains("消费人民币"))
            {
                string weihao = null;
                if (content.Contains("民生银行"))
                {
                    weihao = content.Substring(content.IndexOf("信用卡") + 3, 4);
                    Console.WriteLine("信用卡：{0}", weihao);
                }
                else
                {
                    weihao = content.Substring(content.IndexOf("尾号") + 2, 4);
                    Console.WriteLine("尾号：{0}", weihao);
                }

                string xiaofei = content.Substring(content.IndexOf("消费人民币") + 5);
                decimal cost = isnumeric(xiaofei);
                Console.WriteLine("消费金额：{0}", cost);
                Console.WriteLine("银行:{0}", type(content));
            }

            else
            {
                Console.WriteLine("短信消息没有包含的关键字");
            }
        }

        public static List<string> BankTypeList = new List<string>() { "招商", "交通", "广发", "中信", "民生", "华夏" };
        public static decimal isnumeric(string str)
        {
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            string number = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((ch[i] >= 48 && ch[i] <= 57) || ch[i] == 46 || ch[i] == 44)
                {
                    number += ch[i];
                }
                else
                {
                    break;
                }
            }
            return decimal.Parse(number);
        }
        public static string type(string str)
        {
            foreach (var item in BankTypeList)
            {
                if (str.Contains(item))
                {
                    return item;
                }
            }
            return "";
        }
        public static bool IsCardNumberValid(string cardNumber)
        {
            int i, checkSum = 0;

            // Compute checksum of every other digit starting from right-most digit
            for (i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            // Now take digits not included in first checksum, multiple by two,
            // and compute checksum of resulting digits
            for (i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            // Number is valid if sum of both checksums MOD 10 equals 0
            return ((checkSum % 10) == 0);
        }

    }
}
