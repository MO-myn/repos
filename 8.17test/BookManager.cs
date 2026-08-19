using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _8._17test
{
    internal class BookManager
    {
        public string path { get; }
        public JsonSerializerOptions JsonOpts { get; }

        public string AddBook(Dictionary<string, dynamic> bookDic)
        {
            //新增图书
            List<Dictionary<string, dynamic>> bookList = new();
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                bool resBool = bookList.Exists(item => item["name"].ToString() == bookDic["name"]);
                if (resBool) return "该书籍已存在！！！";
            }
            bookList.Add(bookDic);
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
            File.WriteAllText(path, jsonStr);
            return "新增数据成功!!!";
        }

        //编辑
        public string EditBook(Dictionary<string, dynamic> bookDic)
        {
            if (!File.Exists(this.path)) return "暂时没有书籍，请先添加";
            var str = File.ReadAllText(this.path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(str);
            Dictionary<string, dynamic> findBookDic = list.Find(item => item["name"].ToString() == bookDic["name"]);
            if (findBookDic == null) return "要修改的书籍不存在，请先添加";
            foreach (var item in bookDic)
            {
                findBookDic[item.Key] = bookDic[item.Key];

            }
            File.WriteAllText(this.path, JsonSerializer.Serialize(list, this.JsonOpts));
            return "编辑成功！！！";
        }

        //删除
        public string RemoveBook(string bookName)
        {
            if (!File.Exists(this.path)) return "暂时没有书籍，请先添加";
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            int index = list.FindIndex(item => item["name"].ToString() == bookName);
            if (index == -1) return "要删除的书籍不存在，请先添加";
            list.RemoveAt(index);
            File.WriteAllText(this.path, JsonSerializer.Serialize(list, this.JsonOpts));
            return "删除成功";
        }

        //查询所有
        public List<Dictionary<string, dynamic>> SearcBook()
        {
            List<Dictionary<string, dynamic>> list = new();
            if (!File.Exists(path)) return list;
            var json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            return list;
        }

        //查询单个
        public Dictionary<string, dynamic> SearcBook(string bookName)
        {
            // 查询单个图书的逻辑处理
            // 定义一个图书字典
            Dictionary<string, dynamic> bookDic = new();
            // 判断文件是否存在====>不存在，返回空字典
            if (!File.Exists(path)) return bookDic;
            // 存在===> 读取文件====>反序列化===>根据名称查找====>找不到 ===> 返回空字典
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> resDic = list.Find(item => item["name"].ToString() == bookName);
            if (resDic == null) return bookDic;
            return resDic;
        }

        //自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }
    }
}
