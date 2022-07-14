
namespace JuhaKurisu.Jlib
{
    public static partial class Jlib
    {
        /// <summary>
        /// 与えられた位置に文字があった場合はそれを返し、なかった場合はヌル文字を返す
        /// </summary>
        /// <param name="c">位置</param>
        /// <returns>取得した文字</returns>
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