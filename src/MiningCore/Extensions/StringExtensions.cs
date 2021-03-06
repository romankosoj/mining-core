﻿using System.Globalization;

namespace MiningCore.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        ///     Converts a str string to byte array.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] HexToByteArray(this string str)
        {
            var arr = new byte[str.Length >> 1];

            for (var i = 0; i < str.Length >> 1; ++i)
                arr[i] = (byte) ((GetHexVal(str[i << 1]) << 4) + GetHexVal(str[(i << 1) + 1]));

            return arr;
        }

        private static int GetHexVal(char hex)
        {
            var val = (int) hex;
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }

        public static string ToStringHex8(this uint value)
        {
            return value.ToString("x8", CultureInfo.InvariantCulture);
        }
    }
}
