
namespace JuhaKurisu.Jlib.Ex
{
    public static partial class JEx
    {
        /// <summary>
        /// 与えられた位置に文字があった場合はtrueを返し、文字がなかった場合はfalseを返す
        /// </summary>
        /// <param name="c">位置</param>
        /// <returns>あったか</returns>
        public static bool TryGetValue(this string str, int c, out char value)
        {
            if (str.Length - 1 > c)
            {
                value = str[c];
                return true;
            }
            value = default;
            return false;
        }
    }
}