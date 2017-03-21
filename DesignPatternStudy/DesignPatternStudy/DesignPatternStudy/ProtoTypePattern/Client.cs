using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//场景类
namespace DesignPatternStudy.ProtoTypePattern
{
    public class Client
    {
        private static int MAX_COUNT = 6;

        public static void TestFunc()
        {
            //模拟发送邮件
            int i = 0;
            Mail mail = new Mail(new AdvTemplete());
            mail.tail = "XX银行版权所有";
            while(i<MAX_COUNT)
            {
                mail.appellatopn = getRandString(5) + " 先生（女士）";
                mail.receiver = getRandString(5) + "@" + getRandString(8) + ".com";
                sendMail(mail);
                i++;
            }
        }

        private static void sendMail(Mail mail)
        {
            System.Console.WriteLine("标题=" + mail.subject + "\n收件人=" + mail.receiver + "\n发送成功！");
        }

        private static string  strCH = "abcdefghijklmnopqrstuvwxyz";

        private static string getRandString(int numberCount)
        {
            string str = "";
            for (int index = 0; index < numberCount; index++)
            {
                System.Random random = new Random(10);
                int number = random.Next (0, strCH.Length);
                str += strCH[number] +"";
            }
            return str;
        }
    }
}
