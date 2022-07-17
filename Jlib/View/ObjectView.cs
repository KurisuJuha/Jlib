using System;
namespace JuhaKurisu.Jlib.View
{
    public static partial class JView
    {
        private static string View<T>(string name)
        {
            string s = "";
            if (name != "")
            {
                s = name + "(" + typeof(T).Name + ")" + " : ";
            }
            return s;
        }

        public static string View(this Object obj, string name = "")
        {
            return View<object>(name) + obj.ToString();
        }

        public static string View(this string str, string name = "")
        {
            return View<string>(name) + "\"" + str + "\"";
        }

        public static string View(this char c , string name = "")
        {
            return View<char>(name) + "\'" + c.ToString() + "\'";
        }
    }
}

