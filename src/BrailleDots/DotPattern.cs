using System;
using System.Collections;

namespace BrailleDots
{
    public static partial class DotPattern
    {
        /// <summary>
        /// Returns a braille pattern matching the specified dots depending on which characters
        /// 1-8 are in the string
        /// <br/><br/>
        /// ① ④<br/>
        /// ② ⑤<br/>
        /// ③ ⑥<br/>
        /// ⑦ ⑧
        /// </summary>
        /// <param name="pattern">A string containing the dot numbering</param>
        /// <returns></returns>
        public static char Get(string pattern)
        {
            return Dots[pattern];
        }

        public static char Get(bool[,] pattern)
        {
            if (pattern.Length != 8 || pattern.Rank != 2)
            {
                throw new ArgumentOutOfRangeException(nameof(pattern), "Only 2x4 array sizes supported");
            }

            return Get(new BitArray(new[]
            {
                pattern[0, 0], pattern[1, 0], pattern[2, 0], pattern[0, 1], pattern[1, 1], pattern[2, 1],
                pattern[3, 0], pattern[3, 1]
            }));
        }

        /// <summary>
        /// Returns a braille pattern matching the specified dots based on which bits are true
        /// <br/><br/>
        /// ① ④<br/>
        /// ② ⑤<br/>
        /// ③ ⑥<br/>
        /// ⑦ ⑧
        /// </summary>
        /// <param name="bitArray">A bit array containing the dot numbering</param>
        /// <returns></returns>
        public static char Get(BitArray bitArray)
        {
            if (bitArray.Length != 8)
                throw new ArgumentOutOfRangeException(nameof(bitArray), "Only 8-bit arrays are supported");

            var s = "";
            for (var index = 0; index < bitArray.Count; index++)
            {
                if (bitArray[index])
                {
                    s += (index + 1).ToString();
                }
            }

            return Dots[s];
        }

        /// <summary>
        /// Returns a braille pattern matching the specified dots based on which bits are true
        /// <br/><br/>
        /// ① ④<br/>
        /// ② ⑤<br/>
        /// ③ ⑥<br/>
        /// ⑦ ⑧
        /// </summary>
        /// <param name="pattern">A byte containing the bits to display</param>
        /// <returns></returns>
        public static char Get(byte pattern)
        {
            return Get(new BitArray(new[] {pattern}));
        }

        /// <summary>
        /// Returns a braille pattern matching the specified dots based on which bits are true
        /// <br/><br/>
        /// ① ④<br/>
        /// ② ⑤<br/>
        /// ③ ⑥<br/>
        /// ⑦ ⑧
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <param name="three"></param>
        /// <param name="four"></param>
        /// <param name="five"></param>
        /// <param name="six"></param>
        /// <param name="seven"></param>
        /// <param name="eight"></param>
        /// <returns></returns>
        public static char Get(bool one, bool two, bool three, bool four, bool five, bool six, bool seven, bool eight)
        {
            return Get(new BitArray(new[] {one, two, three, four, five, six, seven, eight}));
        }
    }
}
