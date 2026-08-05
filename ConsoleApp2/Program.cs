namespace ConsoleApp2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            string shu1 = Console.ReadLine();
            int a = int.Parse(shu1);
            Console.WriteLine("请输入第二个数：");
            string shu2 = Console.ReadLine();
            int b = int.Parse(shu2);
            Console.WriteLine($"两个数的和是{a+b}");
            Console.WriteLine("");


            Console.WriteLine("请输入华氏度：");
            string aa = Console.ReadLine();
            int one = int.Parse(aa);
            Console.WriteLine($"摄氏度为：{5 / 9.0 * (one - 32):F3}");
            Console.WriteLine("");


            Console.WriteLine("请输入第一个数：");
            string shu3 = Console.ReadLine();
            int s1 = int.Parse(shu3);
            Console.WriteLine("请输入第二个数：");
            string shu4 = Console.ReadLine();
            int s2 = int.Parse(shu4);
            Console.WriteLine($"交换前：a={s1},b={s2}");
            s1 = s1 + s2;
            s2 = s1 - s2;
            s1 = s1 - s2;
            Console.WriteLine($"交换后：a={s1},b={s2}");
            Console.WriteLine("");


            int h = 89;
            int hour = h % 24;
            int day = h / 24;
            Console.WriteLine($"共{day}天{hour}小时");
            //Console.WriteLine($"共{h % 24}天{h / 24}小时");



        }
    }
}

