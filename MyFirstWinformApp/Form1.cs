using Microsoft.VisualBasic;
using MyFirstWinformApp.Models;
using System.Reflection.Metadata;
using MyFirstWinformApp.common;
using MyFirstWinformApp.common.Interfaces;
using System.Collections;
namespace MyFirstWinformApp  //�ļ���
{
    public partial class Form1 : Form  //�ļ�������ļ�
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bool? bbb;  //Ĭ��ֵλnull
        //int? iii;
        private void Form1_Load(object sender, EventArgs e)
        {
            //bool bi = false;
            //{
            //    //bool bi = false;   �����ǲ��е�
            //    bool bbb = false;  //�����ǿ��Եģ���Ϊbbb�������� 

            //}
            /////��������
            //byte b = 0;
            //byte b1 = byte.MaxValue;
            //byte b2 = byte.MinValue;     //0 ~ 255    8λ

            //short s1 = short.MaxValue;
            //short s2 = short.MinValue;   //-32768 ~ 32767    16λ

            //int i1 = int.MaxValue;
            //int i2 = int.MinValue;       //-2147483648 - 2147483647    32λ

            //long l1 = long.MaxValue;
            //long l2 = long.MinValue;     //                                   64λ


            /////�����Ƚ�
            //short s = 0;
            //int i = 0;
            //i = s;
            ////s = i; ��������д���ᱨ����Ϊshort��Χ < int��Χ 




            /////���������ͼ���Ƚ�
            //float fmax = float.MaxValue;
            //float fmin = float.MinValue;   //-3.4E+38
            //float f = 1.1f;  //С������f����F��Ĭ����double
            //f = s;
            //f = i;
            //f = l1;
            ////l1 = f;  ���ɡ�

            //double dmax = double.MaxValue;
            //double dmin = double.MinValue;
            //double d = 1.1;
            //double d2 = 1.1f;

            //d = f;  //�ϴ�
            ////f=d,����


            //decimal DEmax = decimal.MaxValue;
            //decimal DEmin = decimal.MinValue;
            //decimal DE = 1.1m;
            ////decimal ���Ͳ��ͱ�����ͻ�ͨ��


            //bool Bo = false;
            //bool B1 = 1 == 1;
            //MessageBox.Show(B1.ToString());
            //bool B2 = 1 > 1;  //False
            //MessageBox.Show(B2.ToString());

            ////ֵ����
            //MessageBox.Show(iii.ToString());



            ////�ַ�������
            //int age = 18;
            //string str = "NIHAO"+"i'm from MQ.";
            //string name = "spike";

            //string str2 = $"NIHAO,{name}.my age is{age}";
            //string str3 = $"NIHAO,{name}.my age is"+age;  //string + int = string

            //string str4 = 16.ToString(); //ֱ��ת��
            //MessageBox.Show(str2);    //MessageBox.Show����ֻ����string���͡����������ҪToString

            //char ch = 'H';
            //MessageBox.Show(char.ToString(ch));


            //int xxx = 1;
            //int yyy = xxx + 1; 
            //MessageBox.Show(yyy.ToString());


            ////int xx = iii ?? 1;
            //int xi = iii == null ? 1 : 2;
            //MessageBox.Show(xi++.ToString());   //��ʾΪ1 ������ִ�������֮��xi�ż�1
            //MessageBox.Show((++xi).ToString());   //��ʾΪ2����Ϊ��+��ToString....��.�������ȼ����ڡ�+��������Ҫ�����š�




        }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            //int i = 10;
            //if (i > 10)
            //{
            //    MessageBox.Show("�����i����10");
            //}
            //else
            //{
            //    MessageBox.Show("С�ڵ���10");
            //}
            ////string name = "why";
            //string name = txtUserName.Text;
            //if (name.Equals("why"))
            //{
            //    MessageBox.Show("̫����");
            //}
            //else if (name == "whywhc")
            //{
            //    MessageBox.Show("�Ե�");
            //}
            //else
            //{
            //    MessageBox.Show("���԰�");
            //}
            string number = txtUserName.Text;
            //string res = "";
            //switch (number) 
            //{
            //    //default:
            //    case "100":
            //    case "101":
            //        //res = "101";      �ڶ���д��
            //        MessageBox.Show("���Ѿ�������101or 100���䡣");
            //        break;
            //    case "102":
            //        MessageBox.Show("����102����");
            //        break;
            //    case "103":
            //        MessageBox.Show("zheshi103room");
            //        break;
            //    default:
            //        MessageBox.Show("no room");
            //        break;
            //}
            ////MessageBox.Show($"you have {res}");  �ڶ���д��
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


            //���򵥵�����
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
        /// OUT�÷�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoid_Click(object sender, EventArgs e)
        {
            int res = Add(1, 2);
            MessageBox.Show(res.ToString());
        }

        //����void���� ������ֵ �ĺ���

        int Add(int leftNum, int rightNum)
        {
            return leftNum + rightNum;
        }

        void Sub1(int leftNum, int rightNum, out int res)
        {
            res = leftNum - rightNum;
            //int res2 = leftNum - rightNum;  �����������һ��Ҫ�ж�res��ֵ ������out 
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int res;
            Sub1(1, 2, out res);  //Sb(1,2,out int res)  ����һ��д�������Բ�������дһ�и�ֵ  int res
            MessageBox.Show(res.ToString());
        }


        /// <summary>
        /// REF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRef_Click(object sender, EventArgs e)
        {
            int res = 0;  //ref ���븳��ֵ
            Sub2(4, 3, ref res);
        }
        void Sub2(int leftNum, int rightNum, ref int res)
        {
            res = leftNum - rightNum;
            //int res2 = leftNum - rightNum;  ����������� ��һ�� Ҫ�ж�res��ֵ ������ref�÷� 
        }

        /// <summary>
        /// params
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParams_Click(object sender, EventArgs e)
        {

        }

        void Add2(params int[] ints)   //ֻ����Ϊ���һ����������int res, int opp,params:inst[]��
        {
            int res2 = ints[0] + ints[1];
        }

        private void btnClassDesigne_Click(object sender, EventArgs e)
        {

            //Person zhangsan = new Person();
            //zhangsan.Name = "zhangsan";
            //zhangsan.Age = 18;
            Person zhangsan = new Person()  //������д��new()
            {
                //Id = 1,
                Name = "zhangsan",
                Age = 18
            };
            //Person.Id = 2;
            zhangsan.Eat();
            zhangsan.Run();

            string res = zhangsan.Run();
            //MessageBox.Show(Helper.AddJuhao(res));  //�����Ӹ���ţ�������
            MessageBox.Show(res.AddJuhao());  //resΪstring��������չ����
        }

        private void btnInherit_Click(object sender, EventArgs e)
        {
            object obj = "asvrc";
            string res1 = obj.ToString();  //��һ��д��  obj����Ϊnull
            string res2 = (string)obj;     //�ڶ���д��
            int? res_int = obj as int?;    //asһ���ǿ���Ϊnull�ģ�int���Ͳ�Ϊnull�����Լ�?

            //as���ת���ĸ�ʽ���ԣ���ֱ��ת����null�����ᱨ��
            //���ã���ת�������ᱨ�������ת�������Ͳ���

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
        /// �����滻ԭ��
        /// </summary>
        /// <param name="truck"></param>
        //private void RunCar(Truck truck)
        //{
        //    truck.Run();    //����ֻ���Դ�Truck���͵���ʹ��
        //}
        private void RunCar(Car car)
        {
            //object obj = "asvrc";
            //string res1 = obj.ToString();  //��һ��д��  obj����Ϊnull
            //string res2 = (string)obj;     //�ڶ���д��
            //int? res_int = obj as int?;    //asһ���ǿ���Ϊnull�ģ�int���Ͳ�Ϊnull�����Լ�?

            //as���ת���ĸ�ʽ���ԣ���ֱ��ת����null�����ᱨ��   ���Ƽ�������һ���if�ж��Ƿ�Ϊnull��
            //���ã���ת�������ᱨ�������ת�������Ͳ���   ������Ӱ��ϴ�

            Truck truck1 = (Truck)car;  //���������
            Truck? truck2 = car as Truck;
            car.Run();    //�������Դ�����ΪCar�����͵���ʹ�á����ܽ���TruckҲ���Խ���Suv

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Iuser user = new User();   // �ӿ� ���������� ������� ȥ ʵ����
            ////Iuesr user = new Iuser();  ������
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
            Iusb light = new Light("̨��");

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

            ArrayList arraylist = new ArrayList();  //һ��ʼΪ0�ڴ�
            arraylist.Add(1);
            arraylist.Add("A");
            arraylist.AddRange(arraylist2);
            Console.WriteLine(arraylist);

            arraylist.Insert(1, "B");   //����4bytes  ��->  8  ->16
            arraylist.Reverse();
            Console.WriteLine(arraylist);

            arraylist.RemoveAt(0);        //ɾ����һ��
            Console.WriteLine(arraylist);

            arraylist.Remove("A");       //ɾ��A
            arraylist.RemoveRange(0, 2);  //ɾ������ֵΪ0-2��
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
            //intList.Add("asgh")  �������ָ����
            int i6 = intList[6];
            //���� �� ����
            intList.RemoveAt(0);
            intList.RemoveAt(1);
            intList.RemoveAt(2);
            //i6 = intList[6];  �� out of range


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
            perList2.Remove(new Person() { Age = 100, Name = "wang1" });  //���е������ڴ��ַ��һ��

            //�����ȶ���һ����������Add������var����������ɾ��
            var wang = new Person() { Age = 100, Name = "wangwangwa" };
            perList2.Add(wang);
            perList2.Remove(wang);

            //����  ֱ������ɾ��  
            perList2.Remove(perList[-1]);

            //����ʹ��for each
            //��1��
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

            //��2��
            List<Person> resPersonList = new List<Person>();
            for (int i = 0; i < perList2.Count; i++)
            {
                Person p = perList2[i];
                if (p.Age.Equals(10))
                {
                    resPersonList.Add(p);
                }
            }

            //List������ú���
            _ = perList2.FirstOrDefault(m => m.Age == 10);
            _ = perList2.FindAll(m => m.Age == 10);  //�Լ���ѭ����mΪÿ��ѭ����ֵ��Ȼ���m�����ж�

            //����Ϊʲôֱ�� ���� ɾ��������
            Person p1 = new Person() { Age = 100, Name = "wanghao" };
            Person p2 = new Person() { Age = 100, Name = "wanghao" };
            var h1 = p1.GetHashCode();
            var h2 = p2.GetHashCode();  //��ϣ�벻ͬ��h1

            string s1 = "147";
            string s2 = "147";
            var h3 = s1.GetHashCode();
            var h4 = s2.GetHashCode();  //��ϣ�����h3
        }

        private void btnListShow_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList();
            //frmList.Show();  //�Ӵ��嵯������ʱ����������Բ���
            frmList.ShowDialog();
        }
    }
}
