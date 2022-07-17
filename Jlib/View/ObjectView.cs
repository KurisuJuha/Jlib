using System;
namespace JuhaKurisu.Jlib.View
{
    public static partial class JView
    {
        public static string View(this Object obj, string name = "")
        {
            string s = "";
            if (name != "")
            {
                s = name + " : ";
            }

            return s + obj.ToString();
        }

        public static string View(this string str, string name = "")
        {
            string s = "";
            if (name != "")
            {
                s = name + " : ";
            }

            return s + "\"" + str + "\"";
        }

        public static string View(this char c , string name = "")
        {
            string s = "";
            if (name != "")
            {
                s = name + " : ";
            }

            return s + "\'" + c.ToString() + "\'";
        }
    }
}

