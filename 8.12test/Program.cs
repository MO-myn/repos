using Microsoft.VisualBasic;

namespace _8._12test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //三种调用函数语法
            /*var x = () => {
                Console.WriteLine("----------------");
                
            };
            Console.WriteLine("张三");
            x();
            Console.WriteLine("李四");*/

            /*void x()
            {
                Console.WriteLine("======图书管理系统======");
                Console.WriteLine("1.新增");
                Console.WriteLine("2.修改");
                Console.WriteLine("3.查询");
                Console.WriteLine("4.删除");
            }
            x();*/

            /*Action x = () =>
            {
                Console.WriteLine("  1  ");
                Console.WriteLine(" 222 ");
                Console.WriteLine("33333");
            };
            x();*/

            //带参数的函数
            /*void a(string system) {
                Console.WriteLine($"==={system}===");
                Console.WriteLine("1.新增");
                Console.WriteLine("2.修改");
                Console.WriteLine("3.查询");
                Console.WriteLine("0.退出");
            }
            a("图书管理系统");
            a("学生管理系统");
            a("商品管理系统");*/

            /*Action<string> a = (system) => {
                Console.WriteLine($"==={system}===");
                Console.WriteLine("1.新增");
                Console.WriteLine("2.修改");
                Console.WriteLine("3.查询");
                Console.WriteLine("0.退出");
            };
            a("图书管理系统");
            a("学生管理系统");
            a("商品管理系统");*/

            /* void cal(int n1,int n2,string opt) {
                 *//* if (opt == "+")
                  {
                      Console.WriteLine((n1 + n2).ToString());
                  }
                  else if (opt == "-")
                  {
                      Console.WriteLine((n1 - n2).ToString());
                  }
                  else if (opt == "*")
                  {
                      Console.WriteLine((n1 * n2).ToString());
                  }
                  else if (opt == "/")
                  {
                      Console.WriteLine((n1 / n2).ToString());
                  }
                  else { Console.WriteLine("输入有误"); }*//*

                 var res = opt switch
                 {
                     "+" => (n1 + n2).ToString(),
                     "-" => (n1 + n2).ToString(),
                     "*" => (n1 + n2).ToString(),
                     "/" => (n1 + n2).ToString(),
                 };
                 Console.WriteLine(res );
             }
             cal(10,20,"+");
             cal(10,50,"-");
             cal(10,20,"*");
             cal(100,20,"/");*/

            /*void cal(int n1, int n2, string opt)
            {
                if (opt == "+")
                {
                    Console.WriteLine((n1 + n2).ToString());
                }
                else if (opt == "-")
                {
                    Console.WriteLine((n1 - n2).ToString());
                }
                else if (opt == "*")
                {
                    Console.WriteLine((n1 * n2).ToString());
                }
                else if (opt == "/")
                {
                    Console.WriteLine((n1 / n2).ToString());
                }
                else { Console.WriteLine("输入有误"); }
            }
            cal(opt: "+", n1: 20, n2: 30);
            cal(opt: "-", n1: 20, n2: 30);
            cal(opt: "*", n1: 20, n2: 30);
            cal(opt: "/", n1: 20, n2: 30);*/


            /*double ShowDiscountPrice(double originalPrice, double discount)
            {
                double price = originalPrice * discount;
                return price;
            }
            double res = ShowDiscountPrice(100,0.8);
            Console.WriteLine(res);
            double yun = 0;
            if (res >= 100) yun = res;
            else yun = res + 50;
            Console.WriteLine(yun);*/

            /* var login = (string user, string pwd) =>
             {
                 if (user == "admin" && pwd == "123456")
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             };

             var res = login("admin", "123456");
             Console.WriteLine(res);

             if (res)
             {
                 Console.WriteLine("登录成功,展示主页菜单");
             }
             else
             {
                 Console.WriteLine("登录失败,请重试!!!");
             }*/



            /*var n = () =>
            {
                Console.WriteLine(1);
                return 1+1;
                Console.WriteLine(2);
            };
            n();*/

            /* bool PrintCollection(string[] arr,char con,out string resStr) {
                 resStr = string.Join(con,arr);
                 return true;
             };
             string[] strArr = ["h", "e", "l", "l", "o"];
             var res = PrintCollection(strArr, ' ', out string resStr1);
             Console.WriteLine(res);
             Console.WriteLine(resStr1);*/


            //用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0-100）作为目标数字，不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！
            /*var guessNum = (int n) =>
            {
                
                var random = new Random();
                var x = random.Next(0, 100);
                int count = 1; // 猜测是次数
                while (true)
                {
                    if (n == x)
                    {
                        Console.WriteLine("WIN!");
                        break;// 循环结束
                    }
                    else if (n > x) Console.WriteLine("偏大");
                    else Console.WriteLine("偏小");
                    // 没猜对,继续猜
                    Console.WriteLine("请输入你猜的数字");
                    n = int.Parse(Console.ReadLine());
                    count++;
                    if (count == 5)
                    {   // 游戏次数超过 
                        Console.WriteLine("GAME OVER");
                        break;
                    }
                }
            };

            Console.WriteLine("请输入你猜的数字");
            int m = int.Parse(Console.ReadLine());
            guessNum(m);*/




            //作业
            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            /*double yuan  (double r) 
            {
                double money = 0;
                double S = Math.PI * r * r;
                if (r > 0) {
                    money = S * 200/2;
                    Console.WriteLine($"装修一半需要{money:f2}");
                    
                }
                return S;
            }
            Console.WriteLine("请输入半径");
            int res= int.Parse( Console.ReadLine() );
            yuan(res);*/

            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            /*string str = "qwerysssssqqqqwwweee";
            int x(string str,char b) {
                int c = 0;
                for (int i = 0; i < str.Length; i++) {
                    if (str[i] == b) {
                        c++;
                    }
                }return c;
            }
            Console.Write("请输入要查的字符：");
            string res =Console.ReadLine();

            int result = x(str, res[0]);
            Console.WriteLine(result);*/

            //计算一个整型数组中，最小值第一次出现的下标。
            /*int[] arr = [10, 20, 5, 30, 50, 6, 7];

            Func<int[], int> num = y =>
            {
                int min = y[0]; // 先假定第一个数字是最小值
                int x = 0;//最小值对应下标
                for (int i = 1; i < y.Length; i++) {
                    // 如果当前数字 比我们记录的最小值更小
                    if (y[i] < min) { 
                        min = y[i];// 更新最小值
                        x = i;// 更新最小值的下标
                    }
                }
                return x;
            };
            int res = num(arr);
            Console.WriteLine(res);*/


            //判断一个字符串是否为回文，返回布尔值类型。
            /*string str = "abcdcbab";
            string s=new string(str.Reverse().ToArray());

            if (str == s) { 
                Console.WriteLine("true");
            }
            else { 
                Console.WriteLine("false");
            }
            Console.WriteLine(s);*/
        }
    }
}
