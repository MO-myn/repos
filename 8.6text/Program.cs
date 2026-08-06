namespace _8._6text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将1-10相加
            /*int i = 1;
            int num = 0;
            while (i <= 10)
            {
                num += i;
                i++;
            }
            Console.WriteLine(num);*/

            //将1 - 10之间的奇数加起来
            /*int i = 1;
            int j = 0;
            while (i <= 10) {
                if (i % 2 != 0) {
                    j += i;
                    
                }i++;
            }Console.WriteLine(j);*/

            //输出50以内所有能被3整除且能被5整除的数字
            /*int i = 1;
            int c = 1;
            while (i <= 50)
            {
                if (i % 3 == 0 && i % 5 == 0) {
                    c = i;
                    Console.WriteLine(c);
                }i++;
            }*/

            //1-5相乘
            /*int i = 1;
            int a = 1;
            while (i <= 5)
            {
                a *= i;
                i++;
            }
            Console.WriteLine(a);*/

            //逢7就过的游戏中，100以内所有喊过的数字
            /*int i = 1;
            int q = 1;
            while (i <= 100)
            {
                if (i % 10 == 7)
                {
                    q = i;
                    Console.WriteLine(q);
                }i++;
            }*/

            //求100~1000之间所有的水仙花数
            /* int i = 100;
             int s=0;
             while (i <1000)
             {
                 int a = i / 100;
                 int b = (i / 10) % 10;
                 int c = i % 10;
                 if ((Math.Pow(a,3)+ Math.Pow(b, 3)+ Math.Pow(c, 3)) == i)
                 {
                     s = i;
                     Console.WriteLine(s);
                 }i++;
             }*/

            //do...while循环
            /*int i = 1;
            int a = 1;
            do { 
                a*= i;
                i++;

            }while (i <= 5);
            Console.WriteLine(a);*/

            //倒着输出1-10
            /*for (int i = 10; i>=1; i--) {
                Console.WriteLine(i);            
            }*/

            //输出1-10之间的偶数
            /*for (int i = 1; i <= 10; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }*/

            //入职薪水10K，每年涨幅5 %，50年后工资多少？
            /*double i = 10;
            int y = 1;
            while (y <= 50) {
                i += i * 0.05;
                y++;
               
            } Console.WriteLine(i);*/

            //遍历List：每一个都经历一次
            /*List<string> strList = new()
            {
                "aa",
                "bb",
                "ccc",
                "dd",
                "eee"
            };
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(strList[i]);
            }*/

            //求int型List的所有数据之和
            /* List<int> intList = new()
             {
                 3,
                 5,
                 7,
                 2,
                 9
             };
             int sum = 0;
             for (int i = 0; i < 5; i++) {
                 sum+= intList[i];
             }
             Console.WriteLine(sum);*/

            //判断一个数是否是素数 (素数，就是除了1和自己本身，不能被别的数整除)
            /*Console.WriteLine("输入一个数：");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (i == 1 || i == a)
                {
                    continue;
                }
                if (a % i == 0)
                {
                    Console.WriteLine("不是素数");
                }
            }
            Console.WriteLine("是素数");*/
            //判断一个数是否是素数（break版）
            /*Console.WriteLine("输入一个数：");
            int a = int.Parse(Console.ReadLine());
            bool flag = true;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    flag = false;
                    break; // 找到除数，立刻终止循环
                }
            }

            if (flag)
            {
                Console.WriteLine("是素数");
            }
            else
            {
                Console.WriteLine("不是素数");
            }*/

            //遍历List。
            /* string res = "";
             List<string> arrlist = new List<string>() {"q","w","e","r","t" };
             foreach (string a in arrlist) {
                 //Console.WriteLine(a);
                 res += a;
             }
             Console.WriteLine(res);*/

            // 遍历数组
            /* Dictionary<string, string> dic = new Dictionary<string, string>()
             {
                 {"a","1" },
                 {"b","2" },
                 {"c","3" }
             };
             foreach (var key in dic) {
                 Console.WriteLine(key);
             }*/

            //作业
            //计算100以内偶数的和
            /* int num = 0;
             for (int i=1;i<=100;i++){
                 if (i % 2 == 0) {
                     num += i;
                 }
             }Console.WriteLine(num);*/

            //显示出1000-2000年中所有的闰年，并以每行四个数的形式输出
            /*int count = 0;
            for (int i = 1000; i <= 2000; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.Write(i + "  ");
                    count++;
                    if (count % 4 == 0)
                    { Console.WriteLine(); }
                }
            }*/

            //输出一个倒三角形
            /*for (int j = 9; j>=1; j--) {    //行数
                for (int i = 1; i <= j; i++) {//每行星数
                    Console.Write("*");
                }Console.WriteLine();
            } */

            //用循环计算下面的结果
            //1 - 1/2 + 1/3 - 1/4 + ... - 1/100
            /*double sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    sum += 1.0 / i;
                }
                else if (i % 2 == 0)
                {
                    sum -= 1.0 / i;
                }
            }
            Console.WriteLine(sum);*/

            //求10以内所有数字的阶乘的和
            /*int sum = 0;
            int a = 1;
            for (int i = 2; i <= 10; i++)
            {
                a *= i;
                sum += a;
            }
            Console.WriteLine(sum);*/

            //篮球从5米高的地方掉下来，每次弹起的高度是原来的30%，经过几次弹起，篮球的高度小于0.1米。
            /*  double h = 5;
              int  c = 0;
              while (true) {
                  h = h * 0.3;
                  c++;
                  if (h < 0.1) {
                      break;
                  }
              }Console.WriteLine(c);*/

            //有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量
            /* double kg = 0.00001;//重量
             double sum = 0;//总重量
             double num = 1;//数量
             for (int i = 1; i < 64; i++)
             {
                 sum = sum + kg * num;
                 num = num * 2;
             }
             Console.WriteLine(sum);*/

            //某人在银行有50000元存款。银行每月都要收取服务费，存款大于5000元时每个月收取总额的5%，总额不大于5000元的时候不收服务费；假设这个人存了以后从来都不用，用循环计算银行要扣这个人的手续费能扣多少次？每次扣取后剩余多少钱？
            /*double a = 50000;
            int c = 0;
            while (true) {
                if (a > 5000)
                {
                    a -= a * 0.05;
                    c++;
                }
                else { break; }
            }
            Console.WriteLine($"能扣{c}次");
            Console.WriteLine($"每次扣取后剩余{a}元");*/

            //猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？
            /*int x =1;
            for (int i = 1; i <7; i++) {
                //n/2-1=1
                x = (x + 1) * 2;
            }
            Console.WriteLine(x);*/

            double h = 10;
            double sum = 10;
            for (int i = 1; i <=9; i++) {
                h = h / 2;
                sum += h*2;
            }
            h = h / 2;
            sum += h;

            Console.WriteLine(sum);
        }
    }
}
