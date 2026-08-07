namespace _8._7test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>
            {
                { "name", "张三" },
                { "age", 23 },
                { "height", 178 }
            };*/
            /*foreach (dynamic item in dic) {
                
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }*/
            //var key = dic.Keys;
            //string[] keylist = dic.Keys.ToArray();// 将键集合转为数组
            //List<string> keylist = key.ToList();// 将键集合转为list集合
            //foreach(string k in keylist) Console.WriteLine(k);
            //var key = dic.Values;
            //dynamic[] keylist = dic.Keys.ToArray();
            //List<dynamic> keylist = key.ToList();
            //foreach (dynamic k in keylist) Console.WriteLine(k);

            //思路1：遍历每个元素，让这个元素跟他后面的每一个元素都做比较，相等就删掉
            /*List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            for (int i = 0; i < ints.Count; i++) {
                for (int j = i+1; j < ints.Count;j++) {
                    if (ints[i] == ints[j]) {
                        ints.RemoveAt(j);
                        j--;
                    }
                }
            }
            foreach (int i in ints) Console.WriteLine(i);*/

            //思路2：找元素最后一次出现的下标，跟第一次出现的下标是否相等，相等就表示元素没有重复，不相等就表示有重复，要删除掉最后一个重复元素。
            /*List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            for (int i = 0; i < ints.Count; i++) {
                while (true) {
                    int index = ints.LastIndexOf(ints[i]);// 查找ints[i] 最后一次出现的下标
                    if (index != i)
                    {
                        ints.RemoveAt(index);
                    }
                    else { break; }
                }
            }
            foreach (int n in ints) Console.WriteLine(n);*/
            /*for (int i = 0; i < ints.Count; i++)
            {
                for (int j = ints.Count - 1; j > i; j--)
                {
                    if (ints[j] == ints[i])
                    {
                        ints.RemoveAt(j);
                    }
                }
            }
            foreach (int n in ints) Console.WriteLine(n);*/

            //思路3：利用字典中的键是唯一的，将List中每个数据都作为字典的键，最终在字典中的键都是唯一的，将所有键放在一个新的List中
            /*List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            Dictionary<int, dynamic> tmpDic = new();
            foreach (int item in ints) {
                tmpDic[item] = "www";
            }
            List<int>newList = tmpDic.Keys.ToList();
            foreach (int n in newList) Console.WriteLine(n);*/

            //思路4：创建一个新的List，遍历原本的List，原本List中的每一个元素，放在新的List中进行判断是否存在，如果不存在就添加到新的List中，如果存在就不添加
            /*List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            List<int> newInts = [];
            foreach (int item in ints)
            {
                if (!newInts.Contains(item)) { 
                    newInts.Add(item);
                }
            }
            foreach (int n in newInts) Console.WriteLine(n);*/

            /*List<int> ints = [9, 7, 8, 6, 1, 4,5 , 2, 3];
            for (int j = 0; j < ints.Count-1; j++)
            {
                for (int i = 0; i < ints.Count - 1-j; i++)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        int tmp = ints[i];
                        ints[i] = ints[i + 1];
                        ints[i + 1] = tmp;
                    }
                }
            } foreach (int n in ints) Console.WriteLine(n);*/

            //作业
            /*List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"name", "机械键盘"},
                    {"price", 299.99},
                    {"code", "G001"},
                    {"stock", 120}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "无线鼠标"},
                    {"price", 89.50},
                    {"code", "G002"},
                    {"stock", 356}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "27寸显示器"},
                    {"price", 1299.00},
                    {"code", "G003"},
                    {"stock", 48}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电竞耳机"},
                    {"price", 199.00},
                    {"code", "G004"},
                    {"stock", 85}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电脑支架"},
                    {"price", 69.90},
                    {"code", "G005"},
                    {"stock", 210}
                }
            };
            *//*for (int j = 0; j < goodsList.Count - 1; j++)
            {
                for (int i = 0; i < goodsList.Count - 1 - j; i++)
                {
                    if (goodsList[i]["price"] > goodsList[i + 1]["price"])
                    {
                        dynamic tmp = goodsList[i];
                        goodsList[i] = goodsList[i + 1];
                        goodsList[i + 1] = tmp;
                    }
                }
            }*//*
            Console.WriteLine("请输入查找类型(price/stock)：");
            string a= Console.ReadLine();
            string p = "price";
            string s = "stock";
            Console.WriteLine("请输入排序类型(ASC/DSC)：");
            string b= Console.ReadLine();
            string A = "ASC";
            string D = "DSC";
            if (a == p && b == A)
            {
                for (int j = 0; j < goodsList.Count - 1; j++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - j; i++)
                    {
                        if (goodsList[i]["price"] > goodsList[i + 1]["price"])
                        {
                            dynamic tmp = goodsList[i];
                            goodsList[i] = goodsList[i + 1];
                            goodsList[i + 1] = tmp;
                        }
                    }
                }
            }
            else if (a == p && b == D)
            {
                for (int j = 0; j < goodsList.Count - 1; j++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - j; i++)
                    {
                        if (goodsList[i]["price"] < goodsList[i + 1]["price"])
                        {
                            dynamic tmp = goodsList[i + 1];
                            goodsList[i + 1] = goodsList[i];
                            goodsList[i] = tmp;
                        }
                    }
                }
            }
            else if (a == s && b == A)
            {
                for (int j = 0; j < goodsList.Count - 1; j++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - j; i++)
                    {
                        if (goodsList[i]["stock"] > goodsList[i + 1]["stock"])
                        {
                            dynamic tmp = goodsList[i];
                            goodsList[i] = goodsList[i + 1];
                            goodsList[i + 1] = tmp;
                        }
                    }
                }
            }
            else {
                for (int j = 0; j < goodsList.Count - 1; j++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - j; i++)
                    {
                        if (goodsList[i]["stock"] < goodsList[i + 1]["stock"])
                        {
                            dynamic tmp = goodsList[i + 1];
                            goodsList[i + 1] = goodsList[i];
                            goodsList[i] = tmp;
                        }
                    }
                }
            }
            foreach (dynamic item in goodsList)
            {
                Console.WriteLine($"{item["name"]}--{item["price"]}元--库存{item["stock"]}件");
            }*/


            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

            List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };
            // 用户输入歌手姓名：周杰伦/林俊杰 ==> 通过这个姓名将这个人唱的所有歌曲都找出来
            /*Console.WriteLine("请输入歌手姓名：");
            string singer = Console.ReadLine(); // 周杰伦
            int singerId = 0;
            foreach (Dictionary<string, dynamic> item in singerList)
            {
                if (item["singerName"] == singer) singerId = item["singerId"];
            }
            var singerSongs = new List<Dictionary<string, dynamic>>();
            foreach (dynamic item in songList) 
            {
                if (item["singerId"]== singerId) singerSongs.Add(item);
            }
            foreach(dynamic item in singerSongs) { 
            Console.WriteLine(item["songName"]);
            }*/
            Console.WriteLine("请输入歌曲：");
            string song = Console.ReadLine(); 
            int singerId = 0;
            foreach (Dictionary<string, dynamic> item in songList)
            {
                if (item["songName"] == song) singerId = item["singerId"];
            }
            var singerSongs = new List<Dictionary<string, dynamic>>();
            foreach (dynamic item in singerList)
            {
                if (item["singerId"] == singerId) singerSongs.Add(item);
            }
            foreach (dynamic item in singerSongs)
            {
                Console.WriteLine(item["singerName"]);
            }

        }
    }
}
