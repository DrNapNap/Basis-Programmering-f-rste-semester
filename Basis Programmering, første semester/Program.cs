using System;

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



            for (int y = 0; y < 1; y++)
            {
                Console.WriteLine("        ___________________________________________________________________________________   ");
                Console.WriteLine("");
                for (int x = 0; x < 5; x++)
                {

                    if (x == 0)
                    {
                        Console.Write("");
                    }
                    Console.Write("       |   " + myArrayd.GetLength(myArrayd[y, x]) + "     |");
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




            Loopd();
            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine("        ___________________________________________________________________________________   ");
                Console.WriteLine("");
                for (int x = 0; x < 5; x++)
                {

                    if (x == 0)
                    {


                        Console.Write("| " + (200 * y + 100) + " |");
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

            string[] myArray = new string[] { " Skriv kategorienavn", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            string arrayStrig = myArray[0];

            
            int[] myArrayd = new int[] { 100, 300, 500, 700, 900 };
            int pointSystem1 = myArrayd[0];
            int pointSystem2 = myArrayd[1];
            int pointSystem3 = myArrayd[2];
            int pointSystem4 = myArrayd[3];
            int pointSystem5 = myArrayd[4];
            


            string text = arrayStrig;

            string tolo = text.ToUpper();

            Console.WriteLine();
            Console.WriteLine(tolo);

bool tenker = true;

            string selector = "";
            bool restaet = false;
            do
            {
                restaet = false;

                string[] dwa = new string[] { " Generel viden", "Geografi", "Sprog, litteratur og kunst:", "Historie og mode", "Popkultur og musik" };

                selector = (Console.ReadLine());
                
                if (selector == "Generel viden")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine("Skriv Hvilken sværhedsgrad");
                    selectorSvorhedsGrad = int.Parse( (Console.ReadLine()));

                                                if (tenker == false)
                            {
                                Console.WriteLine("du har været her før du prøver at snyde");
                            }

                  if(tenker == true)
                    { 
                    if (selectorSvorhedsGrad == 100 )
                    {
                        Console.WriteLine("Hvor mange tidszoner er der I Rusland?");
                        Console.WriteLine("");
                        Console.WriteLine("Skriv dit svar her");
                        string rusLand;

                            rusLand = (Console.ReadLine());



                            if (rusLand == "11")
                        {

                            Console.WriteLine("Tillykke du har vundet 100 point");
                                tenker = false;


                            }
                            else
                        {
                            Console.WriteLine("Svaret er ikke korrekt");
                            
                        }
 }}
                    
                    if (selectorSvorhedsGrad == 300)
                    {
                        Console.WriteLine("dwawd");
                    }
                    if (selectorSvorhedsGrad == 500)
                    {

                    }
                    if (selectorSvorhedsGrad == 700)
                    {

                    }else if (selectorSvorhedsGrad == 900) {

                    }else
                    {
                        restaet = true;
                    }

                }
                else if (selector == "Geografi")
                {
                    Console.WriteLine("test");
                }
                else
                {
                    restaet = true;

                    if (restaet == true)
                    {
                        Console.WriteLine("Der er en fail");
                        Console.WriteLine("skive i igen");
                    }
                }


            } while (restaet);
        
            return selector;
        }


        //static string tberegner()
        //{


            
        //}



        static void h1()
        {

            string s = "==============" + " Jeopardy " + "==============";



            string toUpper = s.ToUpper();

            Console.SetCursorPosition((Console.WindowWidth - toUpper.Length) / 4, Console.CursorTop + 2);




            Console.WriteLine(toUpper);

        }


    }
}
