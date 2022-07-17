using System;
namespace JuhaKurisu.Jlib.View
{
    public static partial class JView
    {
        private static string View<T>(string name, string typeName = "")
        {
            string s = "";
            string t = typeof(T).Name;

            if (typeName != "")
            {
                t = typeName;
            }
            if (name != "")
            {
                s = name + "(" + t + ")" + " : ";
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

        public static string View(this int i, string name = "")
        {
            return View<int>(name, "Int") + i;
        }

        public static string View(this float f, string name = "")
        {
            return View<float>(name , "Float") + f;
        }
    }
}

