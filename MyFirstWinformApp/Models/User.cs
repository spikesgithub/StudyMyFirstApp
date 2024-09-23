using MyFirstWinformApp.common;
using MyFirstWinformApp.common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.Models;  //同一个命名空间中不能有两个相同名字的类
class User :Iuser   //类
{
    public User()    //构造函数
    {
        
    }
    public string UserName { get; set; }
    void SayHello()   //方法或者叫类
    {
        MessageBox.Show($"{UserName}zai say nihao ");
    }

    void Iuser.SayHello()
    {
        throw new NotImplementedException();
    }
}
