using System;
using System.IO;

namespace StreamExample
{
    class Program
    {
        /// <summary>
        /// Source: https://msdn.microsoft.com/en-us/library/883dhyx0(v=vs.110).aspx
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long offset;
            int nextByte;

            // alphabet.txt contains "abcdefghijklmnopqrstuvwxyz"
            using (FileStream fs = new FileStream("example.txt", FileMode.Open, FileAccess.Read))
            {
                for (offset = 1; offset <= fs.Length; offset++)
                {
                    // Sets the position/origin of the stream to be at the end of the given value.
                    // TIP: Read the right argument to know where it starts and the count the offset.
                    fs.Seek(-offset, SeekOrigin.End);
                    Console.Write(Convert.ToChar(fs.ReadByte()));
                }
                Console.WriteLine();

                fs.Seek(20, SeekOrigin.Begin);
                // NOTE: letter 'a' = offset 3 in Seek method.
                // The reason for this is the first two bytes represent the encoding of file
                Console.Write("Starting character: " + Convert.ToChar(fs.ReadByte()));

                while ((nextByte = fs.ReadByte()) > 0)
                {
                    Console.Write(Convert.ToChar(nextByte));
                }
                Console.WriteLine();
            }
        }
    }
}