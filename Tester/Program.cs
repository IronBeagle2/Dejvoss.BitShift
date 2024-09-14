using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dejvoss.BitShift;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"Dejvoss.BitShift v{LibInfo.version} tester | (c) DEJVOSS Productions 2024";

            Console.WriteLine("setAt() value 1 into 0b00000000");
            for (int i = 0; i < 8; i++)
            {
                byte output = EightBit.setAt(0b00000000, i, 1);
                Console.WriteLine($"{output.ToString().PadRight(3)} {ByteToString.toBinary(output)} {ByteToString.toHexadecimal(output)}");
            }
            Console.WriteLine();

            Console.WriteLine("setAt() value 0 into 0b11111111");
            for (int i = 0; i < 8; i++)
            {
                byte output = EightBit.setAt(0b11111111, i, 0);
                Console.WriteLine($"{output.ToString().PadRight(3)} {ByteToString.toBinary(output)} {ByteToString.toHexadecimal(output)}");
            }
            Console.WriteLine();

            Console.WriteLine("switchAt() for 0b01010101");
            for (int i = 0; i < 8; i++)
            {
                byte output = EightBit.switchAt(0b10101010, i);
                Console.WriteLine($"{output.ToString().PadRight(3)} {ByteToString.toBinary(output)} {ByteToString.toHexadecimal(output)}");
            }
            Console.WriteLine();

            Console.Write("getAt() 0 of 0b10101010 = ");
            Console.WriteLine(EightBit.getAt(0b10101010, 0));
            Console.Write("getAt() 3 of 0b10101010 = ");
            Console.WriteLine(EightBit.getAt(0b10101010, 3));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
