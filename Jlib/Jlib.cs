
namespace JuhaKurisu.Jlib
{
    public static class Jlib
    {
        public static char TryGet(this string str,int c)
        {
            if (str.Length - 1 > c)
            {
                return str[c];
            }

            return '\0';
        }
    }
}