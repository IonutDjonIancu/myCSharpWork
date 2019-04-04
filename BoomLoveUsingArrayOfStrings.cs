using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction_to_Programming
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string[] arr = {
                @".______     ______     ______   .___  ___.  __      __      __        ______   ____    ____  _______    ____    ____  ______    __    __   __ 
|   _  \   /  __  \   /  __  \  |   \/   | |  |    |  |    |  |      /  __  \  \   \  /   / |   ____|   \   \  /   / /  __  \  |  |  |  | |  |
|  |_)  | |  |  |  | |  |  |  | |  \  /  | |  |    |  |    |  |     |  |  |  |  \   \/   /  |  |__       \   \/   / |  |  |  | |  |  |  | |  |
|   _  <  |  |  |  | |  |  |  | |  |\/|  | |  |    |  |    |  |     |  |  |  |   \      /   |   __|       \_    _/  |  |  |  | |  |  |  | |  |
|  |_)  | |  `--'  | |  `--'  | |  |  |  | |__|    |  |    |  `----.|  `--'  |    \    /    |  |____        |  |    |  `--'  | |  `--'  | |__|
|______/   \______/   \______/  |__|  |__| (__)    |__|    |_______| \______/      \__/     |_______|       |__|     \______/   \______/  (__)",
                @" 
 __ 
/_ |
 | |
 | |
 | |
 |_|",
                @"
 ___  
|__ \ 
   ) |
  / / 
 / /_ 
|____|",
                @"
 ____  
|___ \ 
  __) |
 |__ < 
 ___) |
|____/ "};

            Console.WindowWidth = Console.LargestWindowWidth;
            Console.CursorVisible = false;
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                Console.WriteLine(arr[i]);
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(arr[0]);
            Console.ReadLine();

        }           
    }
}
