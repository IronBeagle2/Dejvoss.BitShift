using System;

namespace Dejvoss.BitShift
{
    public class ByteToString
    {
        // Dejvoss.BitShift.ByteToString
        // (c) DEJVOSS Productions 2024
        // Tools for printing byte values as strings

        //converts (input) to a binary number
        public static String toBinary(byte input)
        {
            return $"0b{Convert.ToString(input, 2).PadLeft(8, '0')}";
        }

        //converts (input) to a hexadecimal number
        public static String toHexadecimal(byte input)
        {
            return $"0x{input.ToString("X2")}";
        }
    }
}
