using Microsoft.VisualBasic;
using MyFirstWinformApp.Models;
using System.Reflection.Metadata;
using MyFirstWinformApp.common;
using MyFirstWinformApp.common.Interfaces;
using System.Collections;
namespace MyFirstWinformApp  //文件夹
{
    public partial class Form1 : Form  //文件夹里的文件
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bool? bbb;  //默认值位null
        //int? iii;
        private void Form1_Load(object sender, EventArgs e)
        {
            //bool bi = false;
            //{
            //    //bool bi = false;   这样是不行的
            //    bool bbb = false;  //这样是可以的，因为bbb在外面了 

            //}
            /////整数类型
            //byte b = 0;
            //byte b1 = byte.MaxValue;
            //byte b2 = byte.MinValue;     //0 ~ 255    8位

            //short s1 = short.MaxValue;
            //short s2 = short.MinValue;   //-32768 ~ 32767    16位

            //int i1 = int.MaxValue;
            //int i2 = int.MinValue;       //-2147483648 - 2147483647    32位

            //long l1 = long.MaxValue;
            //long l2 = long.MinValue;     //                                   64位


            /////整数比较
            //short s = 0;
            //int i = 0;
            //i = s;
            ////s = i; 不能这样写，会报错。因为short范围 < int范围 




            /////浮点数类型及其比较
            //float fmax = float.MaxValue;
            //float fmin = float.MinValue;   //-3.4E+38
            //float f = 1.1f;  //小数不加f或者F，默认是double
            //f = s;
            //f = i;
            //f = l1;
            ////l1 = f;  不可。

            //double dmax = double.MaxValue;
            //double dmin = double.MinValue;
            //double d = 1.1;
            //double d2 = 1.1f;

            //d = f;  //老大
            ////f=d,不可


            //decimal DEmax = decimal.MaxValue;
            //decimal DEmin = decimal.MinValue;
            //decimal DE = 1.1m;
            ////decimal 类型不和别的类型互通。


            //bool Bo = false;
            //bool B1 = 1 == 1;
            //MessageBox.Show(B1.ToString());
            //bool B2 = 1 > 1;  //False
            //MessageBox.Show(B2.ToString());

            ////值类型
            //MessageBox.Show(iii.ToString());



            ////字符串类型
            //int age = 18;
            //string str = "NIHAO"+"i'm from MQ.";
            //string name = "spike";

            //string str2 = $"NIHAO,{name}.my age is{age}";
            //string str3 = $"NIHAO,{name}.my age is"+age;  //string + int = string

            //string str4 = 16.ToString(); //直接转换
            //MessageBox.Show(str2);    //MessageBox.Show里面只能是string类型。所以上面的要ToString

            //char ch = 'H';
            //MessageBox.Show(char.ToString(ch));


            //int xxx = 1;
            //int yyy = xxx + 1; 
            //MessageBox.Show(yyy.ToString());


            ////int xx = iii ?? 1;
            //int xi = iii == null ? 1 : 2;
            //MessageBox.Show(xi++.ToString());   //显示为1 ‘；’执行完结束之后，xi才加1
            //MessageBox.Show((++xi).ToString());   //显示为2，因为先+才ToString....‘.’的优先级大于‘+’。所以要加括号。




        }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            //int i = 10;
            //if (i > 10)
            //{
            //    MessageBox.Show("这里的i大于10");
            //}
            //else
            //{
            //    MessageBox.Show("小于等于10");
            //}
            ////string name = "why";
            //string name = txtUserName.Text;
            //if (name.Equals("why"))
            //{
            //    MessageBox.Show("太对了");
            //}
            //else if (name == "whywhc")
            //{
            //    MessageBox.Show("对的");
            //}
            //else
            //{
            //    MessageBox.Show("不对啊");
            //}
            string number = txtUserName.Text;
            //string res = "";
            //switch (number) 
            //{
            //    //default:
            //    case "100":
            //    case "101":
            //        //res = "101";      第二种写法
            //        MessageBox.Show("你已经进入了101or 100房间。");
            //        break;
            //    case "102":
            //        MessageBox.Show("这是102房间");
            //        break;
            //    case "103":
            //        MessageBox.Show("zheshi103room");
            //        break;
            //    default:
            //        MessageBox.Show("no room");
            //        break;
            //}
            ////MessageBox.Show($"you have {res}");  第二种写法
            string res = number switch
            {
                "101" => "101",
                "102" => "102",
                "103" => "103",
                _ => "101",
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ints = new int[3];
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;

            int[] ints2 = new int[] { 0, 2, 3, 4, 8, 7 };
            ints2[0] = 4;
            ints2[1] = 5;
            ints2[2] = 6;
            ints2[3] = 7;
            ints2[4] = 8;
            ints2[5] = 9;

            int[] ints3 = new int[] {
                0,1,2,3,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24 };


            //更简单的声明
            int[] ints_new = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12 };

            string[] strings = { "ha", "ha", "ha" };
        }

        private void anliyi_Click(object sender, EventArgs e)
        {
            int count = 6;
            double price = 1.9;
            double discount = 0.75;
            double totalPrice = 0;

            totalPrice = count * price;
            if (totalPrice > 10)
            {
                totalPrice *= discount;
            }
        }


        /// <summary>
        /// OUT用法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoid_Click(object sender, EventArgs e)
        {
            int res = Add(1, 2);
            MessageBox.Show(res.ToString());
        }

        //带有void的是 不返回值 的函数

        int Add(int leftNum, int rightNum)
        {
            return leftNum + rightNum;
        }

        void Sub1(int leftNum, int rightNum, out int res)
        {
            res = leftNum - rightNum;
            //int res2 = leftNum - rightNum;  这个函数里面一定要有对res赋值 ，这是out 
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int res;
            Sub1(1, 2, out res);  //Sb(1,2,out int res)  另外一个写法，可以不用另外写一行赋值  int res
            MessageBox.Show(res.ToString());
        }


        /// <summary>
        /// REF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRef_Click(object sender, EventArgs e)
        {
            int res = 0;  //ref 必须赋初值
            Sub2(4, 3, ref res);
        }
        void Sub2(int leftNum, int rightNum, ref int res)
        {
            res = leftNum - rightNum;
            //int res2 = leftNum - rightNum;  这个函数里面 不一定 要有对res赋值 ，这是ref用法 
        }

        /// <summary>
        /// params
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParams_Click(object sender, EventArgs e)
        {

        }

        void Add2(params int[] ints)   //只能作为最后一个参数：（int res, int opp,params:inst[]）
        {
            int res2 = ints[0] + ints[1];
        }

        private void btnClassDesigne_Click(object sender, EventArgs e)
        {

            //Person zhangsan = new Person();
            //zhangsan.Name = "zhangsan";
            //zhangsan.Age = 18;
            Person zhangsan = new Person()  //可以缩写成new()
            {
                //Id = 1,
                Name = "zhangsan",
                Age = 18
            };
            //Person.Id = 2;
            zhangsan.Eat();
            zhangsan.Run();

            string res = zhangsan.Run();
            //MessageBox.Show(Helper.AddJuhao(res));  //给他加个句号，工具类
            MessageBox.Show(res.AddJuhao());  //res为string，这是扩展对象
        }

        private void btnInherit_Click(object sender, EventArgs e)
        {
            object obj = "asvrc";
            string res1 = obj.ToString();  //第一种写法  obj不能为null
            string res2 = (string)obj;     //第二种写法
            int? res_int = obj as int?;    //as一定是可以为null的，int类型不为null，所以加?

            //as如果转换的格式不对，他直接转换成null，不会报错
            //而用（）转换，他会报错，如果想转换的类型不对

            Truck truck = new()
            {
                Color = "purple",
                Length = 8,
                Carriage = "dirt",
            };

            SUV suv = new()
            {
                Carriage = "gab",
                Seat = 6,
            };

            Car car = new Car();
            car = truck;
            MessageBox.Show(car.Color);
            MessageBox.Show(car.Length + "");
            RunCar(truck);
            RunCar(suv);
        }

        /// <summary>
        /// 里氏替换原则
        /// </summary>
        /// <param name="truck"></param>
        //private void RunCar(Truck truck)
        //{
        //    truck.Run();    //这样只可以传Truck类型的来使用
        //}
        private void RunCar(Car car)
        {
            //object obj = "asvrc";
            //string res1 = obj.ToString();  //第一种写法  obj不能为null
            //string res2 = (string)obj;     //第二种写法
            //int? res_int = obj as int?;    //as一定是可以为null的，int类型不为null，所以加?

            //as如果转换的格式不对，他直接转换成null，不会报错   （推荐）但是一般加if判断是否为null。
            //而用（）转换，他会报错，如果想转换的类型不对   （性能影响较大）

            Truck truck1 = (Truck)car;  //父类变子类
            Truck? truck2 = car as Truck;
            car.Run();    //这样可以传父类为Car的类型的来使用。既能接收Truck也可以接收Suv

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Iuser user = new User();   // 接口 必须依赖于 具体的类 去 实例化
            ////Iuesr user = new Iuser();  不可行
            //user.SayHello();
            Iuser user = new User
            {
                UserName = "Wang"
            };

            Truck truck = new Truck(user)
            {
                Carriage = "wang",
            };
            truck.Carriage = "mud";
            truck.Run();
        }

        private void btnDuoTai_Click(object sender, EventArgs e)
        {
            Iusb light = new Light("台灯");

        }

        private void btnOrgStr_Click(object sender, EventArgs e)
        {
            //int i = 1;
            //int j = i;
            //MessageBox.Show(j.ToString());
            //j--;
            //MessageBox.Show(j.ToString());
            //MessageBox.Show(i.ToString());
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList arraylist2 = new ArrayList();
            arraylist2.Add(3);
            arraylist2.Add(4);

            ArrayList arraylist = new ArrayList();  //一开始为0内存
            arraylist.Add(1);
            arraylist.Add("A");
            arraylist.AddRange(arraylist2);
            Console.WriteLine(arraylist);

            arraylist.Insert(1, "B");   //超过4bytes  则->  8  ->16
            arraylist.Reverse();
            Console.WriteLine(arraylist);

            arraylist.RemoveAt(0);        //删除第一个
            Console.WriteLine(arraylist);

            arraylist.Remove("A");       //删除A
            arraylist.RemoveRange(0, 2);  //删除索引值为0-2的
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<int> intList = new List<int>()
            {
                0,1,2,3
            };
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine(intList);
            //intList.Add("asgh")  这个集合指定了
            int i6 = intList[6];
            //扩张 和 收缩
            intList.RemoveAt(0);
            intList.RemoveAt(1);
            intList.RemoveAt(2);
            //i6 = intList[6];  会 out of range


            List<string> stringList = new List<string>()
            {
                "qwe","iu"
            };
            stringList.Add(string.Empty);

            List<Person> personList = new List<Person>();
            Person person = new Person();
            person.Age = 10;
            person.Name = "chang";
            personList.Add(person);
        }

        private void btn_List2_Click(object sender, EventArgs e)
        {
            List<Person> perList = new List<Person>();
            Person person1 = new Person()
            {
                Age = 10,
                Name = "wang",
            };
            perList.Add(person1);
            List<Person> perList2 = new List<Person>()
            {
                new Person(){Age=100,Name="wang1"},
                new Person(){Age = 101,Name="wang2"},
            };
            //perList.RemoveAt(0);
            perList2.Remove(new Person() { Age = 100, Name = "wang1" });  //不行的两个内存地址不一样

            //所以先定义一个变量，再Add。再有var，可以索引删掉
            var wang = new Person() { Age = 100, Name = "wangwangwa" };
            perList2.Add(wang);
            perList2.Remove(wang);

            //或者  直接索引删除  
            perList2.Remove(perList[-1]);

            //或者使用for each
            //（1）
            Person resPerson = null;
            for (int i = 0; i < perList2.Count; i++)
            {
                Person p = perList2[i];
                if (p.Age == 10)
                {
                    resPerson = p;
                    break;
                }
            }

            //（2）
            List<Person> resPersonList = new List<Person>();
            for (int i = 0; i < perList2.Count; i++)
            {
                Person p = perList2[i];
                if (p.Age.Equals(10))
                {
                    resPersonList.Add(p);
                }
            }

            //List里的内置函数
            _ = perList2.FirstOrDefault(m => m.Age == 10);
            _ = perList2.FindAll(m => m.Age == 10);  //自己会循环，m为每个循环的值。然后对m进行判断

            //解释为什么直接 等于 删除不可行
            Person p1 = new Person() { Age = 100, Name = "wanghao" };
            Person p2 = new Person() { Age = 100, Name = "wanghao" };
            var h1 = p1.GetHashCode();
            var h2 = p2.GetHashCode();  //哈希码不同于h1

            string s1 = "147";
            string s2 = "147";
            var h3 = s1.GetHashCode();
            var h4 = s2.GetHashCode();  //哈希码等于h3
        }

        private void btnListShow_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList();
            //frmList.Show();  //子窗体弹出来的时候，主窗体可以操作
            frmList.ShowDialog();
        }
    }
}
