using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.Models
{
    internal class Person
    {
        //public static int Id { get; set; }  //static之后，这个类有且只有一个Id，实例化之后也只有一个，不能改了
        public  int Id { get; set; }
        public string Name { get; set; }  //private  私有，内部访问
        public int Age { get; set; }
        public void Eat()
        {
            MessageBox.Show($"{Name}吃饭");
        }
        public string Run()
        {
            return $"{Name}跑步,今年{Age}.";
        }
       public void rain()
        {
            MessageBox.Show("天在下雨");
        }
    }
}
