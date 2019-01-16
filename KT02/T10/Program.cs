using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Surprise");
            Console.WriteLine("2.Surprise");
            Console.WriteLine("3.Surprise");
            Console.WriteLine("4.Surprise");

            while (true)
            {


                Console.Write("Your choise > ");
                int c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine("                $$$$");
                    Console.WriteLine("              $$    $$");
                    Console.WriteLine("              $$    $$");
                    Console.WriteLine("              $$    $$");
                    Console.WriteLine("              $$    $$");
                    Console.WriteLine("              $$    $$");
                    Console.WriteLine("          $$$$$$    $$$$$$");
                    Console.WriteLine("        $$    $$    $$    $$$$");
                    Console.WriteLine("        $$    $$    $$    $$  $$");
                    Console.WriteLine("$$$$$$  $$    $$    $$    $$    $$");
                    Console.WriteLine("$$    $$$$                $$    $$");
                    Console.WriteLine("$$      $$                      $$");
                    Console.WriteLine("  $$    $$                      $$");
                    Console.WriteLine("   $$$  $$                      $$");
                    Console.WriteLine("    $$                          $$");
                    Console.WriteLine("     $$$                        $$");
                    Console.WriteLine("      $$                      $$$");
                    Console.WriteLine("       $$$                    $$");
                    Console.WriteLine("        $$                    $$");
                    Console.WriteLine("         $$$                $$$");
                    Console.WriteLine("          $$                $$");
                    Console.WriteLine("          $$$$$$$$$$$$$$$$$$$$");
                }

                if (c == 2)
                {
                    Console.WriteLine(@"    /@");
                    Console.WriteLine(@"    \ \");
                    Console.WriteLine(@"  ___> \");
                    Console.WriteLine(@" (__O)  \");
                    Console.WriteLine(@"(____@)  \");
                    Console.WriteLine(@"(____@)   \");
                    Console.WriteLine(@" (__o)_    \");
                    Console.WriteLine(@"       \    \");
                }

                if (c == 3)
                {
                    Console.WriteLine(@"       __    EEEK!");
                    Console.WriteLine(@"      /  \   ~~|~~");
                    Console.WriteLine(@"     (|00|)    |");
                    Console.WriteLine(@"      (==)  --/");
                    Console.WriteLine(@"    ___||___");
                    Console.WriteLine(@"   / _ .. _ \");
                    Console.WriteLine(@"  //  |  |  \\");
                    Console.WriteLine(@" //   |  |   \\");
                    Console.WriteLine(@" ||  / /\ \  ||");
                    Console.WriteLine(@"_|| _| || |_ ||");
                    Console.WriteLine(@"\|||___||___|||/");
                }

                if (c == 4)
                {
                    Console.WriteLine(@"___    ___     ___     _________     ___        __                    ___    __");
                    Console.WriteLine(@"\ /    \ /     \ /    |/  | |  \|    \  \      / /         /\         \  \   \/");
                    Console.WriteLine(@"| |    | |     | |        | |        |\  \    // |        /. \        ||\ \  ||");
                    Console.WriteLine(@"| |____| |     | |        | |        ||\  \  //| |       // \ \       || \ \ ||");
                    Console.WriteLine(@"| |    | |     | |        | |        || \  \// | |      //___\ \      ||  \ \||");
                    Console.WriteLine(@"| |    | |     | |        | |        ||  \  /  | |     //     \ \     ||   \  |");
                    Console.WriteLine(@"/_\    /_\     /_\        /_\       /_\   \/   /_\    /_\     /__\   /__\   \_|");
                    Console.WriteLine();
                    Console.WriteLine(@"                                    /|");
                    Console.WriteLine(@"                                    \\  \`.");
                    Console.WriteLine(@"    _      _   _   _           ,'/  ||   ) `.                _        _");
                    Console.WriteLine(@"   |_) |  / \ / \ | \        ,' (   //,-'_,-'    ,   |\  /| / \ |\ | |_ \ /");
                    Console.WriteLine(@"   |_) |_ \_/ \_/ |_/  .    `-._`-.  |  (_____,-'/   | \/ | \_/ | \| |_  |");
                    Console.WriteLine(@"                       \`-._____)  | | ,-'-.    /");
                    Console.WriteLine(@"                        \    ,-'-. | |/     ) ,'");
                    Console.WriteLine(@"                         `. (     \|     _,','");
                    Console.WriteLine(@"                           `.`._");
                }
            }
        }
    }
}
