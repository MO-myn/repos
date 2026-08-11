using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;

namespace _8._11test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "7-16-30-38-49-52-63-70";
            string result = ""; // 最终获取到的情报

            string[] nums = salt.Split("-");
            for (int i = 0; i < nums.Length; i++) { 
                int index=int.Parse(nums[i]);
                result += text[index];
            }
            Console.WriteLine(result); // 午夜渡口交换情报*/

            /*string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "午夜渡口交换情报";
            List<int> nums = [];
            for (int i = 0; i < salt.Length; i++) {
                // 转换为整数 才能作为下标使用
                int index = text.IndexOf(salt[i]);
                nums.Add(index);
            }
            string result = string.Join("-", nums);///将集合的元素按照指定的符号拼接为字符串
            Console.WriteLine(result);//7-16-30-38-49-52-63-70*/

            //为了更安全，生成密文的时候可以调整下标：（上一个字符）
            /*string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "午夜渡口交换情报";
            List<int> nums = [];
            for (int i = 0; i < salt.Length; i++)
            {
                // 转换为整数 才能作为下标使用
                int index = text.IndexOf(salt[i])-1;
                nums.Add(index);
            }
            string result = string.Join("-", nums);///将集合的元素按照指定的符号拼接为字符串
            Console.WriteLine(result);//6-15-29-37-48-51-62-69*/

            //奇数就-1，偶数就+1
            /*string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "午夜渡口交换情报";
            List<int> nums = [];
            for (int i = 0; i < salt.Length; i++)
            {
                // 转换为整数 才能作为下标使用
                int index = text.IndexOf(salt[i]);
                index += index % 2 == 0 ? 1 : -1;
                nums.Add(index);
            }
            string result = string.Join("-", nums);///将集合的元素按照指定的符号拼接为字符串
            Console.WriteLine(result);//6-17-31-39-48-53-62-71
            string res = ""; // 最终获取到的情报
                             // 先将result密文 转为数组
            string[] nums1 = result.Split("-");
            for (int i = 0; i < nums1.Length; i++)
            {
                int index = int.Parse(nums1[i]);
                // 判断下标是奇数还是偶数，奇数就 -1，偶数就 +1：
                index += index % 2 == 0 ? 1 : -1;
                res += text[index];
            }
            Console.WriteLine(res); // 午夜渡口交换情报*/


            //数字转汉字 
            /* //int money = 147258369;
             int money = 10000690;
             string str= money.ToString();
             // 创建汉字数组
             string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
             // 创建单位数组
             string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿", "拾亿"];
             string result = "";//最终结果
             for (int i = str.Length-1; i>=0;i--) {
                 int idx = int.Parse(str[i].ToString());
                 //如果数字不是0 或单位是萬 则单位都保留
                 int index = str.Length - 1 - i;
                 if (idx != 0 || units[index] == "萬")
                 {
                     result = arr[idx] + units[index] + result;
                 }
                 else
                 {//如果数字是0 或单位不是萬 则单位都不保留
                     *//*if (str.Length - 5 == i)
                     {
                         result = arr[idx] + units[4] + result;
                     }
                     else {
                         result = arr[idx] + result;
                     }*//*
                     result = arr[idx] + result;
                 }
             }
             //用正则把零+萬替换成萬
             result = Regex.Replace(result, @"零+萬", "萬");
             result = Regex.Replace(result, @"零+", "零");
             if (result.EndsWith("零")) {
                 result = result.Substring(0, result.Length - 1);
             } 
             Console.WriteLine(result);*/

            //数字格式化
            /* Console.WriteLine(1234.5678.ToString("C2"));//￥1,234.57
             Console.WriteLine(1234.ToString("D10"));//0000001234  整数位补全，只能处理整数
             Console.WriteLine(1234.5678.ToString("E3"));//1.23E+003(1.23*10^3)
             Console.WriteLine(1234.5678.ToString("f3"));//1234.568
             Console.WriteLine(1234.5678.ToString("P1"));//123,456.8%  百分比表示，保留小数点位数
             Console.WriteLine(15.ToString("X"));//F 仅能转整数(十六进制)
             Console.WriteLine(12.34.ToString("000000.000%"));//001234.000% 补全位数，转百分比
             Console.WriteLine(12345678.ToString("#,#"));//12,345,678
             Console.WriteLine(1234.5678.ToString("0.0%"));//123456.8%*/

            //时间对象 
            /*var date=DateTime.Now;// 获取当前时间
            Console.WriteLine(date);
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;
            var dayOfWeek = date.DayOfWeek;
            var hour = date.Hour;
            var minute = date.Minute;
            var second = date.Second;
            var milliSecond = date.Millisecond;
            Console.WriteLine($"年={year},月={month},日={day},周={dayOfWeek},时={hour},分={minute},秒={second},毫秒={milliSecond}");*/

            //获取指定日期时间：
            /*DateTime d =new DateTime(2003,10,04,10,10,10);
            Console.WriteLine(d);
            //强制转换为DateTime
            DateTime d1 = DateTime.Parse("2003-10-04 10:10:10");
            Console.WriteLine(d1);*/

            //日期时间运算：
            DateTime d1=DateTime.Now;
            /*DateTime d2=d1.AddDays(2);
            // 时间差
            TimeSpan d3 = d2 - d1;
            Console.WriteLine(d3); // 1.00:00:00 
            // 总天数
            var allDays = d3.TotalDays;
            Console.WriteLine(allDays); // 2
            // 总小时数
            var allHours = d3.TotalHours;
            Console.WriteLine(allHours); // 48*/

            /*Console.WriteLine(d1.ToString("d"));//2026/8/11
            Console.WriteLine(d1.ToString("D"));//2026年8月11日
            Console.WriteLine(d1.ToString("t"));//20:00
            Console.WriteLine(d1.ToString("T"));//20:00:11
            Console.WriteLine(d1.ToString("f"));//2026年8月11日 20:00
            Console.WriteLine(d1.ToString("F"));//2026年8月11日 20:00:11
            Console.WriteLine(d1.ToString("g"));//2026/8/11 20:00
            Console.WriteLine(d1.ToString("G"));//2026/8/11 20:00:11
            Console.WriteLine(d1.ToString("M"));//8月11日
            Console.WriteLine(d1.ToString("Y"));//2026年8月
            Console.WriteLine(d1.ToString("U"));//2026年8月11日 12:00:11
            Console.WriteLine(d1.ToString("R"));//Tue, 11 Aug 2026 20:00:11 GMT*/

        }
    }
}
