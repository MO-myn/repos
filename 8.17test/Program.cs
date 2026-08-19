
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _8._17test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
            });


            string num = "";
            while (num != "0")
            {
                Console.WriteLine("=====欢迎来到图书管理系统=====");
                Console.WriteLine("1：新增图书");
                Console.WriteLine("2：删除图书");
                Console.WriteLine("3：编辑图书");
                Console.WriteLine("4：查询所有图书");
                Console.WriteLine("5：查询单个图书");
                Console.WriteLine("0：退出");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("---新增图书---");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        //double price = double.Parse(Console.ReadLine()); 
                        if (!double.TryParse(Console.ReadLine(), out double price))
                        {
                            Console.WriteLine("价格输入格式错误，新增图书终止！");
                        }
                        Dictionary<string, dynamic> bookDic = new()
                        {
                            ["name"] = bookName,
                            ["author"] = author,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price,
                        };
                        string res = BM.AddBook(bookDic);
                        Console.WriteLine(res);
                        break;
                    case "2":
                        Console.WriteLine("---删除图书---");
                        string removeBN = Console.ReadLine();
                        string resStr = BM.RemoveBook(removeBN);
                        Console.WriteLine(resStr);
                        break;
                    case "3":
                        Console.WriteLine("---编辑图书---");
                        Console.WriteLine("请输入书名");
                        string editBookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string editAuthor = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string editMark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        //double editPrice = double.Parse(Console.ReadLine());
                        string editPrice = Console.ReadLine();
                        //@"^[0-9]+[0-9]*(\.[0-9]+)?$"
                        if (Regex.IsMatch(editPrice, @"^[0-9]+[0-9]*(\.[0-9]+)?$"))
                        {


                            Dictionary<string, dynamic> editBook = new()
                            {
                                ["name"] = editBookName,
                                ["author"] = editAuthor,
                                ["mark"] = editMark,
                                ["price"] = editPrice
                            };
                            string resEditStr = BM.EditBook(editBook);
                            Console.WriteLine(resEditStr);
                        }
                        else Console.WriteLine("价格输入格式错误，编辑图书终止！");
                        break;
                    case "4":
                        Console.WriteLine("---查询所有图书---");
                        var resList = BM.SearcBook();
                        if (resList.Count == 0) Console.WriteLine("没有书籍，请先添加");
                        else
                        {
                            foreach (var item in resList)
                            {
                                Console.WriteLine($"书名：{item["name"]} - 作者：{item["author"]} - 标签：{item["mark"]} - 价格：{item["price"]}");
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("---查询单个图书---");
                        Console.WriteLine("请输入查询的书名");
                        string searchBookName = Console.ReadLine();
                        var resBook = BM.SearcBook(searchBookName);
                        if (resBook.Count == 0) Console.WriteLine("没找到对应的数据，请先添加");
                        else Console.WriteLine($"书名：{resBook["name"]} - 作者：{resBook["author"]} - 标签：{resBook["mark"]} - 价格：{resBook["price"]}");
                        break;
                    case "0":
                        Console.WriteLine("---退出---");
                        break;
                    default:
                        Console.WriteLine("***输入有误***");
                        break;
                }
            }


        }
    }

}
