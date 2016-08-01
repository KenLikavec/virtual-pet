using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //MY VIRTUAL PET PROJECT DUG
            MyVirtualPet Dug = new MyVirtualPet("Dug", 50, 50, 50);
            string secondHangAnswer;
            Console.WriteLine("Would you like to spend time with your buddy Dug the Golden retriever? (YES/NO)" );
            string hangAnswer = Console.ReadLine().ToUpper();
            Console.Clear();

            if (hangAnswer == "YES")
            {
                do
                {
                    //Console.Clear(); and Console.Writeline(); are used for better visual representation when program is running.

                    //Dug greeting
                    Dug.Tick();
                    Console.WriteLine("Dug: \"Yay! I'm so excited!\"");
                    Console.WriteLine();
                    Console.WriteLine("Click enter to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    Dug.printDetails();
                    Console.WriteLine();
                    Dug.Feed();
                    Console.Clear();

                    Dug.printDetails();
                    Console.WriteLine();
                    Dug.activePup();
                    Console.Clear();

                    Dug.printDetails();
                    Console.WriteLine();
                    Dug.training();
                    Console.Clear();
                    Dug.printDetails();

                    Console.WriteLine();
                    Console.WriteLine("Would you guys like to do anything else? (YES/NO)");
                    secondHangAnswer = Console.ReadLine().ToUpper();
                    Console.Clear();
                }
                while (secondHangAnswer == "YES");
            }
            else if (hangAnswer == "NO")
            {
                Console.WriteLine("Aww poor Dug :(");
            }








            Dug.printDetails();
            Console.WriteLine();
            Console.WriteLine("Dug: \"Can't wait to see you next time best friend!\"");
            Console.ReadKey();
        }
    }
}
