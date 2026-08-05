using System.Security;

namespace _8._5text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//小红想做车模，车模条件年龄16~22
            Console.WriteLine("请输入小红的年龄：");
            int age = int.Parse(Console.ReadLine());
            bool a = age >= 16 && age <= 22;
            Console.WriteLine(a);*/


            /*//小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值
            Console.WriteLine("请输入小红的资产：");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入小红的颜值：");
            double face = double.Parse(Console.ReadLine());
            bool x = money >= 300 || face > 9.5;
            Console.WriteLine(x);*/


            /* //小明是真男人，去了一趟泰国，回来就反了
             Console.WriteLine("请输入小明的性别：");
             string sex = Console.ReadLine();
             bool y = !(sex == "男") ;
             Console.WriteLine(y);*/


            /* //根据输入的成绩判断是不及格(小于60),及格(大于60小于80), 良好(大于80小于90),优秀(大于90小于100)
             Console.WriteLine("请输入成绩：");
             double score = double.Parse(Console.ReadLine());
             if (score > 90 && score <= 100)
             {
                 Console.WriteLine("优秀");
             }
             else if (score >= 80 && score < 90)
             {
                 Console.WriteLine("良好");
             }
             else if (score >= 60 && score < 80)
             {
                 Console.WriteLine("及格");
             }
             else {
                 Console.WriteLine("不及格");
             }*/


            /*//输入年份，判断是否是闰年(普通闰年：能被4整除但不能被100整除 / 世纪闰年：可以被400整除)
            Console.WriteLine("请输入年份：");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 4 != 0)
            {
                Console.WriteLine("普通闰年");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("世纪闰年");
            }
            else { Console.WriteLine("不是闰年"); } */


            /* Console.WriteLine("请输入数字判断星期几：");
             int week = int.Parse(Console.ReadLine());
             if (week >= 1 && week <= 7) {
                 switch (week) {
                     case 1: Console.WriteLine("星期一"); break;
                     case 2: Console.WriteLine("星期二"); break;
                     case 3: Console.WriteLine("星期三"); break;
                     case 4: Console.WriteLine("星期四"); break;
                     case 5: Console.WriteLine("星期五"); break;
                     case 6: Console.WriteLine("星期六"); break;
                     case 7: Console.WriteLine("星期日"); break;
                     default: break;
                 }
             }
             else { Console.WriteLine("请输入正确数字"); }*/


            /* // 输入分数 1~100
             // 判断等级输出
             // 分数90~100  输出A  ===> 分数的十位9 / 10
             // 分数80~90   输出B  ===> 分数的十位8
             // 分数70~80   输出C  ===> 分数的十位7
             // 分数60~70   输出D  ===> 分数的十位6
             // 分数1~60    输出F  ===> 分数的十位0/1/2/3/4/5

             Console.WriteLine("输入分数 1~100：");
             int score = int.Parse(Console.ReadLine());
             if (score > 0 && score <= 100)
             {
                 int res = score / 10;
                 switch (res)
                 {
                     case 0: Console.WriteLine($"{score}分是F等级"); break;
                     case 1: Console.WriteLine($"{score}分是A等级"); break;
                     case 2: Console.WriteLine($"{score}分是F等级"); break;
                     case 3: Console.WriteLine($"{score}分是F等级"); break;
                     case 4: Console.WriteLine($"{score}分是F等级"); break;
                     case 5: Console.WriteLine($"{score}分是F等级"); break;
                     case 6: Console.WriteLine($"{score}分是D等级"); break;
                     case 7: Console.WriteLine($"{score}分是C等级"); break;
                     case 8: Console.WriteLine($"{score}分是B等级"); break;
                     case 9: Console.WriteLine($"{score}分是A等级"); break;
                     case 10: Console.WriteLine($"{score}分是A等级"); break;
                 }
             }else { Console.WriteLine("输入的分数有问题"); }*/

            /*// 输出星期几  6-7输出周末  穿透写法
            Console.WriteLine("请输入数字判断星期几：");
            int week = int.Parse(Console.ReadLine());
            if (week >= 1 && week <= 7)
            {
                switch (week)
                {
                    case 1: Console.WriteLine("星期一"); break;
                    case 2: Console.WriteLine("星期二"); break;
                    case 3: Console.WriteLine("星期三"); break;
                    case 4: Console.WriteLine("星期四"); break;
                    case 5: Console.WriteLine("星期五"); break;
                    case 6: 
                    case 7: Console.WriteLine("星期末"); break;
                    default: break;
                }
            }
            else { Console.WriteLine("请输入正确数字"); }*/


            /*//成绩等级输出 switch 简写
            Console.WriteLine("输入分数 1~100：");
            int score = int.Parse(Console.ReadLine());
            if (score > 0 && score <= 100)
            {
                string res = score switch
                {
                    //表达式=>结果，_=>结果 ，_表示default
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };
                Console.WriteLine(res);
            }
            else { Console.WriteLine("输入的分数有问题"); }*/


            /*//三元表达式:判断 成年了/ 未成年
            Console.WriteLine("请输入年龄：");
            int age = int.Parse(Console.ReadLine());
            string res = age >= 18 ? "成年了" : "未成年";
            Console.WriteLine(res);*/


            /*//三元表达式: 判断 闰年(能被4整除但不能被100整除, 能被400整除) 平年
            Console.WriteLine("请输入年份：");
            int year = int.Parse(Console.ReadLine());
            string res = (year % 4 == 0 && year % 400 == 0) || (year % 100 != 0) ? "闰年" : "平年";
            Console.WriteLine(res);*/

            //奇数偶数判断
            /*Console.WriteLine("请输入一个数：");
            int s=int.Parse(Console.ReadLine());
            string res =(s%2==0)?"偶数":"奇数";
            Console.WriteLine(res);*/


            /*//文件大小单位不同（1024以下kb / 以上MB）
            Console.WriteLine("请输入一个数：");
            int B = int.Parse(Console.ReadLine());
            string res1 = (B >=1024) ? "MB" : "kb";
            Console.WriteLine(res1);*/

            /*//数学运算计算器：让用户输入两个数字，再输入一个运算符(+ - * /)，判断输入的运算符是什么，对两个数字进行对应的数学运算，将结果输出
            Console.WriteLine("请输入第一个数：");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符(+ - * /)");
            string y = Console.ReadLine();
            switch (y) {
                case "+": Console.WriteLine($"{a1}+{a2}={a1 + a2}");break;
                case "-": Console.WriteLine($"{a1}-{a2}={a1 - a2}"); break;
                case "*": Console.WriteLine($"{a1}*{a2}={a1 * a2}"); break;
                case "/": Console.WriteLine($"{a1}/{a2}={a1 / a2}"); break;
                default: Console.WriteLine("输入的运算符有误"); break;
            }*/


            /*//不同血型不同性格：输入血型，当血型为A时，输出"细心稳重"；当血型为B时，输出"乐观自由"；当血型为AB时，输出"思维多变"；当血型为O时，输出"热情外向"
            Console.WriteLine("请输入血型：");
            string x=Console.ReadLine();
            switch (x)
            {
                case "A": Console.WriteLine("细心稳重"); break;
                case "B": Console.WriteLine("乐观自由"); break;
                case "AB": Console.WriteLine("思维多变"); break;
                case "O": Console.WriteLine("热情外向"); break;
                default: Console.WriteLine("输入的血型有误"); break;
            }*/

            //作业
            /*//账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功；账号不对，就输出账号不存在；密码不对，就输出密码错误。
            Console.WriteLine("请输入账号：");
            string z=Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string p=Console.ReadLine();
            if (z == "admin")
            {
                if (p == "123456")
                {
                    Console.WriteLine("登入成功");
                }
                else
                {
                    Console.WriteLine("密码错误");
                }
            }
            else {
                Console.WriteLine("账号不对");
            }*/

            /* //选择菜单（add/edit/del）执行操作（练习多分支和switch）：提示用户选择菜单（add/edit/del），判断输入的是add，就输出新增成功；输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。
             Console.WriteLine("请选择菜单（add/edit/del）");
             string menu = Console.ReadLine();
             if (menu == "add")
             {
                 Console.WriteLine("新增成功");
             }
             else if (menu == "edit")
             {
                 Console.WriteLine("编辑成功");
             }
             else if (menu == "del")
             {
                 Console.WriteLine("删除成功");
             }
             else {
                 Console.WriteLine("输入的菜单有误");
             }*/
            /*switch (menu)
            {
                case "add": Console.WriteLine("新增成功"); break;
                case "edit": Console.WriteLine("编辑成功"); break;
                case "del": Console.WriteLine("删除成功"); break;
                default: Console.WriteLine("输入的菜单有误"); break;
            }*/

            /* //会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：让用户输入自己的类型（VIP/USER）和消费金额，如果是VIP，判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，也输出他应该支付的金额；如果是USER，判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
             Console.WriteLine("请输入用户类型（VIP/USER）");
             string type = Console.ReadLine();
             Console.WriteLine("请输入消费金额：");
             double money = double.Parse(Console.ReadLine());
             if (type == "VIP" && money >= 1000)
             {
                 Console.WriteLine($"尊贵的VIP用户，您的消费的金额为：{money}");
             }
             else if (type == "USER" && money >= 2000)
             {
                 Console.WriteLine($"尊贵的VIP用户，您的消费的金额为：{money}");
             }
             else
             {
                 Console.WriteLine($"尊贵的{type}用户，您的消费的金额为：{money}");
             }*/
            /*if (type == "VIP") {
                if (money >= 1000)
                { Console.WriteLine($"尊贵的VIP用户，您的消费的金额为：{money}"); }
                else { Console.WriteLine($"尊贵的VIP用户，您的消费的金额为：{money}"); }
            } else if(type == "USER" ){
                if (money >= 2000)
                { Console.WriteLine($"尊贵的VIP用户，您的消费的金额为：{money}"); }
                else { Console.WriteLine($"尊贵的VIP用户，您的消费的金额为：{money}"); }
            }*/

            /*//通过月份判断季节（练习switch的穿透写法）：用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；如果是6、7、8月份，就输出这是夏季；如果是9、10、11月份，就输出这是秋季，如果是12、1、2月份，就输出这是冬季。
            Console.WriteLine("请输入月份：");
            int month = int.Parse(Console.ReadLine());
            switch (month) {
                case 3:
                case 4:
                case 5: Console.WriteLine("这是春季"); break;
                case 6:
                case 7:
                case 8: Console.WriteLine("这是夏季"); break;   
                case 9:
                case 10:
                case 11: Console.WriteLine("这是秋季"); break;  
                case 12:
                case 1: 
                case 2: Console.WriteLine("这是冬季"); break;
                default: Console.WriteLine("输入的月份有误"); break;
            }
            *//* string m = month switch
             {
                 3 or 4 or 5 => "春季",
                 6 or 7 or 8 => "夏季",
                 9 or 10 or 11 => "秋季",
                 12 or 1 or 2 => "冬季",
                 _ => "输入的月份有误"
             };
             Console.WriteLine(m);*/

            //快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；如果重量在1Kg~5Kg之间，就输出快递费20元；如果重量超过5Kg，就输出快递费50元。
            Console.WriteLine("请输入快递重量");
        }
    }
}
