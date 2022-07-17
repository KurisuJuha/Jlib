using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuhaKurisu.Jlib
{
    public static partial class Jlib
    {
        /// <summary>
        /// 指定したキーの値が存在していたらその値を返し、存在していなかったらDefault値を返す
        /// </summary>
        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
        {
            return dict.TryGetValue(key, out TValue result) ? result : default(TValue);
        }
    }
}
