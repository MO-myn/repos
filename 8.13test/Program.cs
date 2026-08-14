namespace _8._13test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*void sayHi(string userName) { Console.WriteLine($"Hi:{userName}"); }
            void sayHello(string userName) { Console.WriteLine($"Hello:{userName}"); }
            void sayBye(string userName) { Console.WriteLine($"byeybe:{userName}"); }

            Action<string> say = sayHi;
            say += sayBye;
            say("jeck");*/

            /*int[] arr = [10,20,30];
            arr[0] = 1;
            int[] arr2 = [ 100, 200, 300];
            arr2[0] = arr[0];
            Console.WriteLine(arr2[0]);*/

            // 返回：年龄、性别、是否成年
            /*(int age, string gender, bool isAdult) GetPersonInfo()
            {
                Console.Write("请输入年龄：");
                int age = int.Parse(Console.ReadLine());
                Console.Write("请输入性别：");
                string gender = Console.ReadLine();
                bool isAdult = age >= 18;
                return (age, gender, isAdult);
            }
            (int age, string gender, bool isAdult) item = GetPersonInfo();
            Console.WriteLine($"年龄：{item.age},性别：{item.gender},是否成年：{item.isAdult}");*/

            /*Action fn =() => {
                Console.WriteLine("2222");
            };

            var ff = (Action f) => {
                Console.WriteLine("1111");
                f();
            };

            ff(fn);*/

            /* List<int> list = [100,200,300,400,500];
             var res =list.Exists(item=>
             {
                 //Console.WriteLine(item);
                 return item > 100;

             });
             Console.WriteLine(res);*/

            //作业
            List<Dictionary<string, dynamic>> list = new()
            {
                new Dictionary<string, dynamic>(){
                    ["name"] = "zs",
                    ["age"] = 29,
                    ["isMan"] = true,
                    ["isSingle"] = true,
                    ["salary"] = 4200
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ls",
                    ["age"] = 20,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 3400
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ww",
                    ["age"] = 19,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 6000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zl",
                    ["age"] = 14,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "sq",
                    ["age"] = 35,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 7000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zb",
                    ["age"] = 27,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2900
                },
            };
            // Find: 要求查找年龄小于20的
            var list1 = list.Find((item => item["age"] < 20));
            //Console.WriteLine(string.Join(" , ", list1));
            Console.WriteLine($"{list1["name"]}--{list1["age"]}");
            Console.WriteLine();

            // FindLast: 要求查找年龄大于25的
            var list2 = list.FindLast((item => item["age"] > 25));
            Console.WriteLine(string.Join(" , ", list2));
            Console.WriteLine();

            // FindAll: 找出性别男的
            var list3 = list.FindAll((item => item["isMan"] == true));
            foreach (var res in list3) Console.WriteLine(string.Join(" , ", res));
            Console.WriteLine();

            // FindIndex: 找出薪水大于5000
            var list4 = list.FindIndex((item => item["salary"] > 5000));
            Console.WriteLine(list4);
            Console.WriteLine();

            // FindLastIndex: 找出薪水小于3000
            var list5 = list.FindLastIndex((item => item["salary"] < 3000));
            Console.WriteLine(list5);
            Console.WriteLine();

            // Exists: 判断是否有薪水大于5000
            var list6 = list.Exists(item => { return item["salary"] > 5000; });
            Console.WriteLine(list6);
            Console.WriteLine();

            // ForEach: 输出每个的 名字-年龄-薪水
            list.ForEach(item => Console.WriteLine($"姓名{item["name"]}-年龄{item["age"]}-薪水{item["salary"]}"));
            /*List<string> x = [];
            list.ForEach(fn =>
            {
                x.Add($"{fn["name"]}-{fn["age"]}-{fn["salary"]}");
            });
            x.ForEach(item => Console.WriteLine(item));*/
            Console.WriteLine();

            // ConvertAll: 映射得到一个所以薪水的list
            List<dynamic> newList = list.ConvertAll(item => item["salary"]);
            Console.WriteLine(string.Join(",", newList));
            Console.WriteLine();

            //TrueForAll: 判断是否都成年
            bool list7 = list.TrueForAll(item => item["age"] > 18);
            Console.WriteLine(list7);
            Console.WriteLine();

            //封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数
            //List<string> list8 = ["aaabbbccdcdavvahusb"];
            Func<string, Dictionary<char, int>> count = str =>
            {
                Dictionary<char, int> dict = new();
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    dict[c] = dict.ContainsKey(c) ? dict[c] + 1 : 1;
                }
                return dict;
            };
            var list8 = count("aaabbbccdcdavvahusb");
            foreach (var item in list8) Console.WriteLine($"{item.Key}:{item.Value}");
            
            
        }
    }
}
