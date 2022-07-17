using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuhaKurisu.Jlib
{
    public static partial class Jlib
    {
        public static bool TryGetValue<T>(this T[] array, int index, out T value)
        {
            value = default;

            // マイナスの場合false
            if (index < 0) return false;

            // 範囲外の場合false
            if (array.Length - 1 < index) return false;

            value = array[index];
            return true;
        }
    }
}
