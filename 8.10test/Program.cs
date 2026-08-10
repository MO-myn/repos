using System.ComponentModel;
using System.Text.RegularExpressions;

namespace _8._10test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//利用遍历对字符串去重
            string str = "abcedjjsssabcd";
            string resStr = "";
            for (int i = 0; i < str.Length; i++) {
                int j = 0;
                for (; j < resStr.Length; j++) {
                    if (str[i] == resStr[j]) break;
                }
                if (j == resStr.Length) resStr += str[i];
            }
            Console.WriteLine(resStr);*/

            /*//Substring：截取字符串
            string str = "ahvsbfkjsb";
            //string res = str.Substring(2);
            string res = str.Substring(2,3);
            Console.WriteLine(res);*/

            /* //Contains：判断字符串中是否包含小字符串（子串）
             string str = "ahvsbfkjsb";
             //bool a=str.Contains("jsb");
             bool a=str.Contains("jb");
             Console.WriteLine(a);*/

            /*//Contains：判断字符串中是否包含小字符串（子串）去重
            string str = "abcedjjsssabcd";
            string resStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!resStr.Contains(str[i])) resStr += str[i];
            }
            Console.WriteLine(resStr);*/

            //Replace：将字符串中指定的子串都替换成的新的子串
            /*string str = "生活总会有大麻烦, 黑夜总会过去";
            // 假设list存储敏感词
            List<string> mgc = ["大麻", "夜总会"];
            foreach (string s in mgc)
            {
                *//*string news = "";
                for (int i = 0; i < s.Length; i++)
                {
                    news += "**";*//*
                    str = str.Replace(s, "**");
                //}
            }
            Console.WriteLine(str);*/

            //"you love i"`转成`"I Love You"`
            /*string oldstr = "you love i";
            string[] strArr = oldstr.Split();
            List<string> strList = new();
            foreach (string str in strArr) strList.Add(str);
            strList.Reverse();
            string resStr = "";
            foreach (string item in strList) { 
                string fisrtLetter = item.Substring(0,1).ToUpper();
                string otherLetter = item.Substring(1).ToLower();
                resStr += fisrtLetter + otherLetter + " ";
            }
            Console.WriteLine(resStr.Substring(0,resStr.Length-1 ));
            */

            /* string reg = @"ac";
             string str = "bac";
             Match res = Regex.Match(str, reg);
             Console.WriteLine(res.Value); // a*/

            /*string reg = @"a";
            bool res = Regex.IsMatch("bac", reg);
            Console.WriteLine(res); // True
            bool res1 = Regex.IsMatch("bcd", reg);
            Console.WriteLine(res1); // False*/

            /* var reg = @"^\d{3}$";
             Console.WriteLine(Regex.IsMatch("123a123",reg ));//False
             Console.WriteLine(Regex.IsMatch("123",reg ));//True
             Console.WriteLine(Regex.IsMatch("111",reg ));//True
             Console.WriteLine(Regex.IsMatch("12dggs",reg ));//False
             Console.WriteLine(Regex.IsMatch("1sddfe233",reg ));//False*/


            /*string reg = @"a|b";
            MatchCollection res = Regex.Matches("abc", reg);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);*/

            //分组
            /*string reg = @"(?:\d{4})-(?:\d{2})-(?:\d{2})";
            Match res = Regex.Match("2026-07-22", reg);
            Console.WriteLine(res.Value); // 2026-07-22
            Console.WriteLine(res.Groups[0]); // 2026-07-22
            Console.WriteLine(res.Groups[1]); // 
            Console.WriteLine(res.Groups.Count); // 1*/


            //作业
            //提取一句话中所有的中文姓名
            /* string str = "hello, I am 刘德华,your name is 黎明?";
             var zw = @"[\u4e00-\u9fa5]{2,}";
             var res = Regex.Matches(str, zw);
             foreach(var item in res) Console.WriteLine(item);*/
            //替换所有多余空格
            /*string str = "abc  dd  ee  ff  gg  HH  h j k";
            string reg = @" ";
            string res = Regex.Replace(str, reg, "_");
            Console.WriteLine(res);*/
            //身份证号码
            /* string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
             // 书写正则, 找到字符串中的身份证号及 出生年,月,日
             var sfz = @"\d{17}\w{1}";
             var res = Regex.Matches(str, sfz);
             foreach (var item in res) Console.WriteLine(item);*/

            Console.WriteLine("请输入密码:");
            string pwd = Console.ReadLine();
            string p = @"\w[!@#$%^&*]{8,15}$";
            Match res = Regex.Match(pwd, p);
        }
    }
}
