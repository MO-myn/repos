namespace _8._14test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Action writeLog = () =>
            {
                Console.WriteLine("输入：");
                string opt = Console.ReadLine();
                var aaa = @"./content.log";
                File.WriteAllText(aaa,$"{opt}\t"+DateTime.Now);
            };
            writeLog();*/

           /* Func<string, int> isFileorDir = path =>
            {
                // 说明path是文件
                if (File.Exists(path)) return 1;
                // 说明path是目录
                if (Directory.Exists(path)) return 2;
                return 0;
            };
            string[] resArr = ["NO", "isfile", "isDir"];
            //int res = isFileorDir("./");
            //int res = isFileorDir("./content.log");
            //Console.WriteLine(resArr[res]);

            Func<string, List<string>> getFileAndDir = path =>
            {
                List<string> resList = [];
                // 判断路径是否是目录,如果不是目录则 手动抛出一个异常
                if (isFileorDir(path) != 2) throw new Exception("传递的参数有误,必须要是目录路径");
                // 获取目录下的所有文件
                string[] files = Directory.GetFiles(path);
                resList.AddRange(files);
                // 获取所有的目录
                string[] dirs = Directory.GetDirectories(path);
                resList.AddRange(dirs);
                return resList;
            };
            //var res = getFileAndDir("./");
            var res = getFileAndDir(@"D:\视觉02");
            foreach (var item in res) Console.WriteLine(item);*/


            //使用读写文件配合命令行窗口  模拟实现注册功能
            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)
            Action writeLog = () =>
            {
                Console.WriteLine("请输入用户名：");
                string user = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string pwd = Console.ReadLine();
                var aaa = @"./user.txt";
                File.AppendAllText(aaa, $"用户名：{user} -- 密码：{pwd}\n" );
                File.AppendAllText(aaa, $"=======================\n" );

            };
            writeLog();

        }
    }
}
