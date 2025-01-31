using System;
using System.Collections.Generic;

namespace ChComboListGenerator.Core
{
    class Print
    {
        private static Dictionary<string, ConsoleColor> colorMap = new Dictionary<string, ConsoleColor>
            {
                { "BLACK", ConsoleColor.Black },
                { "DARKBLUE", ConsoleColor.DarkBlue },
                { "DARKGREEN", ConsoleColor.DarkGreen },
                { "DARKCYAN", ConsoleColor.DarkCyan },
                { "DARKRED", ConsoleColor.DarkRed },
                { "DARKMAGENTA", ConsoleColor.DarkMagenta },
                { "DARKYELLOW", ConsoleColor.DarkYellow },
                { "GRAY", ConsoleColor.Gray },
                { "DARKGRAY", ConsoleColor.DarkGray },
                { "BLUE", ConsoleColor.Blue },
                { "GREEN", ConsoleColor.Green },
                { "CYAN", ConsoleColor.Cyan },
                { "RED", ConsoleColor.Red },
                { "MAGENTA", ConsoleColor.Magenta },
                { "YELLOW", ConsoleColor.Yellow },
                { "WHITE", ConsoleColor.White }
            };
        public static void Write(string input)
        {
            string[] parts = input.Split(new[] { '{', '}' }, StringSplitOptions.None);

            foreach (var part in parts)
            {
                if (colorMap.ContainsKey(part.ToUpper()))
                {
                    Console.ForegroundColor = colorMap[part.ToUpper()];
                }
                else
                {
                    Console.Write(part);
                }
            }
            Console.ResetColor();
        }

        public static void WriteLine(string input)
        {
            string[] parts = input.Split(new[] { '{', '}' }, StringSplitOptions.None);

            foreach (var part in parts)
            {
                if (colorMap.ContainsKey(part.ToUpper()))
                {
                    Console.ForegroundColor = colorMap[part.ToUpper()];
                }
                else
                {
                    Console.Write(part);
                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void WriteLineListColorize(string[] text)
        {
            foreach (string t in text)
            {
                Write(t);
                //Console.Write(t);
            }
            Console.WriteLine();
        }
        public static void WriteLineList(string[] text)
        {
            foreach (string t in text)
            {
                //Write(t);
                Console.Write(t);
            }
            Console.WriteLine();
        }
    }
}
