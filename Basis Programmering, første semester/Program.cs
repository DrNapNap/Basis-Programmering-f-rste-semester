using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis_Programmering__første_semester
{
    class Program
    {


        static void Main(string[] args)
        {


            Start();



            




            Console.Read();
        }


     
           static void Loopd()
        {
            int[,] myArrayd = new int[1, 5];

            string[] myArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            string arrayStrig = myArray[4];
            Console.WriteLine(arrayStrig);

            for (int y = 0; y < 1; y++)
            {
                Console.WriteLine("     ___________________________________________________________________________   ");
                Console.WriteLine("");
                for (int x = 0; x < 5; x++)
                {

                    if (x == 0)
                    {
                        Console.Write("");
                    }
                    Console.Write("        " + myArrayd.GetLength(myArrayd[y, x]) + "     |");
                }

                Console.WriteLine("");


            }

        }




    static void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Velkommen til Jeopardy");
            Console.WriteLine("");

            Console.WriteLine("E for at start");
            while (Console.ReadKey().Key != ConsoleKey.E)
            {




            }
            Console.Clear();
            h1();

            Category();





        }




        static void Category()
        {





            int[,] myArray = new int[5, 5];

           

            Loopd();
            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine("        ___________________________________________________________________________________   ");
                Console.WriteLine("");
                for (int x = 0; x < 5; x++)
                {

                    if (x == 0)
                    {
                        

                        Console.Write("| " + (200 * y + 100  ) + " |");
                    }
                    Console.Write("      " + (200 * y + 100) + "       |");
                }

                Console.WriteLine("");


            }
            Console.WriteLine("        ___________________________________________________________________________________   ");
            Console.WriteLine("");
            Categoryselector();
        }






    static string Categoryselector()
        {


            string text = "Skive kategorienavn";

            string tolo = text.ToUpper();

            Console.WriteLine();
            Console.WriteLine(tolo);

            

            string selector = "";
 bool restaet = false;
            do
            {
                restaet = false;

 

                selector = (Console.ReadLine());

                if (selector == "1")
                {


                    Console.WriteLine("3");
                }
                else if (selector == "2")
                {
                    Console.WriteLine("test");
                }
                else
                {
                    restaet = true;
                    
                    if (restaet == true )
                    {
                      Console.WriteLine("Der er en fail");
                        Console.WriteLine("skive i igen");
                    }
                }
 
                
            } while (restaet);
            Console.WriteLine("dwa");
return selector;
        }



  

    static void h1()
        {
          
            string s = "==============" + " Jeopardy " + "==============";



            string toUpper = s.ToUpper();

            Console.SetCursorPosition((Console.WindowWidth - toUpper.Length) / 4, Console.CursorTop + 2);

           

            
            Console.WriteLine(toUpper);
       
        }



}
}
