using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.common;

public static class Helper   //工具类，用static再合适不过了。
{
    //public static string AddJuhao(string str)
    public static string AddJuhao(this string str)
    {
        return str + ".";
    }
}
