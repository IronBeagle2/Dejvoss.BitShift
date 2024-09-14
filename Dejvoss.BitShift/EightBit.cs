using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejvoss.BitShift
{
    public class EightBit
    {
        // Dejvoss.BitShift.EightBit
        // (c) DEJVOSS Productions 2024
        // Tools for working with 8bit byte values

        //sets bit in (input) at (pos) to (value)
        public static byte setAt(byte input, int pos, int value)
        {
            if (value == 1)
                return (byte)(input | (1 << pos));
            else
                return (byte)(input & ~(1 << pos));
        }

        //returns bit in (input) at (pos)
        public static int getAt(byte input, int pos)
        {
            return (input >> pos) & 1;
        }

        //switches bit in (input) at (pos) [1 -> 0; 0 -> 1]
        public static byte switchAt(byte input, int pos)
        {
            int value = getAt(input, pos);

            if (value == 0)
                return (byte)(input | (1 << pos));
            else
                return (byte)(input & ~(1 << pos));

        }
    }
}
