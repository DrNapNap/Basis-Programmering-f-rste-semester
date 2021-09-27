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
            bool tenkerd = true;
            
            bool dawdwadw = true;


            bool dddda = true;
            bool tenker2 = true;
            bool solen = true;
            bool jorden = true;
            bool hovedstad = true;
            bool dwadaw = true;

            bool dawdadaw = true;

            
            int a = 12;
            int b = 12;


            int v = a + b;
            Console.WriteLine(v);

            do
            {
                restaet = false;

                string[] dwa = new string[] { " Generel viden", "Geografi", "Sprog, litteratur og kunst:", "Historie og mode", "Popkultur og musik" };

                selector = (Console.ReadLine());

                if (selector == "Generel viden")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine("Skriv Hvilken sværhedsgrad");
                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (tenker == false)
                    {
                        Console.WriteLine("du har været her før du prøver at snyde");
                    }

                    if (tenker == true)
                    {
                        if (selectorSvorhedsGrad == 100)
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
                        }
                    }
                    
                    if (tenkerd == true)
                    {
                        if (selectorSvorhedsGrad == 300)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvad er Japans nationalblomst? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string nationalBlomst;

                            nationalBlomst = (Console.ReadLine());



                            if (nationalBlomst == "Kirsebærblomst")
                            {

                                Console.WriteLine(" Tillykke du har vundet 300 point");
                                tenkerd = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }
                    
                    if (tenker2 == true)
                    {
                        if (selectorSvorhedsGrad == 500)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvor mange striber er der på det amerikanske flag? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string amerikanske;

                            amerikanske = (Console.ReadLine());



                            if (amerikanske == "13")
                            {

                                Console.WriteLine(" Tillykke du har vundet 500 point");
                                tenker2 = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }
                    if (dawdwadw == true)
                    {
                        if (selectorSvorhedsGrad == 700)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvad er Australiens nationaldyr? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string nationalDyr;

                            nationalDyr = (Console.ReadLine());



                            if (nationalDyr == "Rød Kæmpekænguru")
                            {

                                Console.WriteLine(" Tillykke du har vundet 700 point");
                                dawdwadw = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }


                   else if  (dddda == true)
                    {
                        if (selectorSvorhedsGrad == 900)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvor mange dage tager det for jorden at dreje rundt om solen? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string rusLand;

                            rusLand = (Console.ReadLine());



                            if (rusLand == "365")
                            {

                                Console.WriteLine(" Tillykke du har vundet 900 point");
                                dddda = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }
                    else
                    {
                        restaet = true;
                    }
}

                if (selector == "Geografi")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine("Skriv Hvilken sværhedsgrad");
                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (tenker == false)
                    {
                        Console.WriteLine("du har været her før du prøver at snyde");
                    }
                   
                    if (dawdadaw == true)
                    {
                        if (selectorSvorhedsGrad == 100)
                        {
                            Console.WriteLine("Hvilket land i verden har flest øer?");
                            Console.WriteLine("");
                            Console.WriteLine("Skriv dit svar her");
                            string rusLand;

                            rusLand = (Console.ReadLine());



                            if (rusLand == "220000" || rusLand == "220.000")
                            {

                                Console.WriteLine("Tillykke du har vundet 100 point");
                                dawdadaw = false;


                            }
                            else
                            {
                                Console.WriteLine("Svaret er ikke korrekt");

                            }
                        }
                    }
                    
                    if (dwadaw == true)
                    {
                        if (selectorSvorhedsGrad == 300)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvad er det mindste land i verden? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string vatikanstaten;

                            vatikanstaten = (Console.ReadLine());



                            if (vatikanstaten == "Vatikanstaten" || vatikanstaten == "vatikanstaten")
                            {

                                Console.WriteLine(" Tillykke du har vundet 300 point");
                                dwadaw = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }
                    
                    if (hovedstad == true)
                    {
                        if (selectorSvorhedsGrad == 500)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvad er Canadas hovedstad? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string amerikanske;

                            amerikanske = (Console.ReadLine());



                            if (amerikanske == "Ottowa" || amerikanske == "ottowa")
                            {

                                Console.WriteLine(" Tillykke du har vundet 500 point");
                                hovedstad = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }

                    
                    if (jorden == true)
                    {
                        if (selectorSvorhedsGrad == 700)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvor er det laveste naturlige sted på jorden? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string nationalDyr;

                            nationalDyr = (Console.ReadLine());



                            if (nationalDyr == "11.034" || nationalDyr == "11034" || nationalDyr == "11000")
                            {

                                Console.WriteLine(" Tillykke du har vundet 700 point");
                                jorden = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }

                    
                    else if (solen == true)
                    {
                        if (selectorSvorhedsGrad == 900)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvor mange dage tager det for jorden at dreje rundt om solen? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string rusLand;

                            rusLand = (Console.ReadLine());



                            if (rusLand == "365")
                            {

                                Console.WriteLine(" Tillykke du har vundet 900 point");
                                solen = false;


                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }
                    else
                    {
                        restaet = true;
                    }
                }


            } while (restaet);

            return selector;
        }


      //static string tberegner()
      // {



      //  }



        static void h1()
        {

            string s = "==============" + " Jeopardy " + "==============";



            string toUpper = s.ToUpper();

            Console.SetCursorPosition((Console.WindowWidth - toUpper.Length) / 4, Console.CursorTop + 2);




            Console.WriteLine(toUpper);

        }


    }
}
