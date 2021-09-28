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

        static void Velkommen()
        {
            string[] myArray = new string[] { " Velkommen til Jeopardy ", " Quizmasteren placerer spillepladen med jetonerne foran sig og opstiller 6 svar/spørgsmålskort i kortholderen.      ", " Quizmasteren placerer spillepladen med jetonerne foran sig og opstiller 6 svar/spørgsmålskort i kortholderen.      ", " og kategorien vender ud mod deltagerne.       ", " Deltagerne i spillet må naturligvis ikke kunne se spørgsmål/svar-siden af kortene.       ", " Klik E for at starte " };
            string arrayStrig = myArray[0];
            string kategori = myArray[1];
            string arrayStri = myArray[2];
            string kategor = myArray[3];
            string d = myArray[4];
            string S = myArray[5];

            Console.WriteLine();
            Console.WriteLine(arrayStrig);
            Console.WriteLine("");

            Console.WriteLine(kategori);
            Console.WriteLine(arrayStri);
            Console.WriteLine(kategor);
            Console.WriteLine(d);
            Console.WriteLine(S);
            Console.WriteLine();
        }


        static void Start()
        {

            Velkommen();
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



            string[] myArray = new string[] { " Skriv kategorienavn", "Skriv din kategori igen", "3", "4", "5", "6", "7", "8", "9", "10" };
            string arrayStrig = myArray[0];
            string kategori = myArray[1];


            //pointsystemet
            int[] myArrayd = new int[] { 99, 299, 499, 699, 899 };
            int pointSystem1 = myArrayd[0];
            int pointSystem3 = myArrayd[1];
            int pointSystem5 = myArrayd[2];
            int pointSystem7 = myArrayd[3];
            int pointSystem9 = myArrayd[4];

            int score = 0;


            

            string text = arrayStrig;

            string tolo = text.ToUpper();

            Console.WriteLine();
            Console.WriteLine(tolo);

            //Selector
            string selector = "";


            //Tjek om du har været inde i det samme spørgsmål
            bool tenker = true;          
            bool tenkerd = true;         
            bool dawdwadw = true;
            bool dddda = true;
            bool tenker2 = true;
            bool solen = true;
            bool jorden = true;
            bool hovedstad = true;
            bool dwadaw = true;
            bool dawdadaw = true;




            // restart som der er stavet forkert
            bool restaet = false;
            do
            {


                if (restaet == true)
                {

                    Console.WriteLine(kategori);
                }


                restaet = false;

                string[] dwa = new string[] { " Generel viden", "Geografi", "Sprog, litteratur og kunst:", "Historie og mode", "Popkultur og musik" };


                selector = (Console.ReadLine());

                if (selector == "Generel viden")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine(" Skriv Hvilken sværhedsgrad");

                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (tenker == false)
                    {

                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }

                    if (tenkerd == false)
                    {

                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }
                    if (tenker2 == false)
                    {

                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }
                    if (dawdwadw == false)
                    {

                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }
                    if (dddda == false)
                    {

                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }


                    if (tenker == true)
                    {
                        if (selectorSvorhedsGrad == 100)
                        {
                            Console.WriteLine(" Hvor mange tidszoner er der I Rusland?");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her");
                            Console.WriteLine("");
                            string rusLand;

                            rusLand = (Console.ReadLine());



                            if (rusLand == "11")
                            {

                                Console.WriteLine(" Tillykke du har vundet 100 point");
                                
                                tenker = false;

                                if (tenker == false)
                                {
                                    do
                                    {
                                        score += pointSystem1;
                                        ++score;
                                    } while (tenker);
                                }

                                Console.WriteLine();
                                Console.WriteLine(" score: " + score);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Svaret er ikke korrekt");
                                Console.WriteLine();
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
                                if (tenkerd == false)
                                {
                                    do
                                    {
                                        score += pointSystem3;
                                        ++score;
                                    } while (tenkerd);
                                }
                                Console.WriteLine();
                                Console.WriteLine(" score: " + score);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Svaret er ikke korrekt");
                                Console.WriteLine();
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

                                if (tenker2 == false)
                                {
                                    do
                                    {
                                        score += pointSystem5;
                                        ++score;
                                    } while (tenker2);
                                }
                                Console.WriteLine();
                                Console.WriteLine(" score: " + score);
                                Console.WriteLine();
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

                                if (dawdwadw == false)
                                {
                                    do
                                    {
                                        score += pointSystem7;
                                        ++score;
                                    } while (dawdwadw);
                                }
                                Console.WriteLine();
                                Console.WriteLine(" score: " + score);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }


                    else if (dddda == true)
                    {
                        if (selectorSvorhedsGrad == 900)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvor mange dage tager det for jorden at dreje rundt om solen? ");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her ");
                            string S;

                            S = (Console.ReadLine());



                            if (S == "365")
                            {

                                Console.WriteLine(" Tillykke du har vundet 900 point");
                                dddda = false;
                                if (dddda == false)
                                {
                                    do
                                    {
                                        score += pointSystem9;
                                        ++score;
                                    } while (dddda);
                                }
                                Console.WriteLine();
                                Console.WriteLine("score: " + score);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

                            }
                        }
                    }

                    restaet = true;



                }

                if (selector == "Geografi")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine(" Skriv Hvilken sværhedsgrad");
                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (tenker == false)
                    {
                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }

                    if (dawdadaw == true)
                    {
                        if (selectorSvorhedsGrad == 100)
                        {
                            Console.WriteLine(" Hvilket land i verden har flest øer?");
                            Console.WriteLine("");
                            Console.WriteLine(" Skriv dit svar her");
                            string verden;
                            verden = (Console.ReadLine());



                            if (verden == "220000" || verden == "220.000")
                            {

                                Console.WriteLine(" Tillykke du har vundet 100 point");
                                dawdadaw = false;

                                if (dawdadaw == false)
                                {
                                    do
                                    {
                                        score += pointSystem1;
                                        ++score;
                                    } while (dawdadaw);
                                }
                                Console.WriteLine();
                                Console.WriteLine("score: " + score);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine(" Svaret er ikke korrekt");

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


                                if (dwadaw == false)
                                {
                                    do
                                    {
                                        score += pointSystem3;
                                        ++score;
                                    } while (dwadaw);
                                }
                                Console.WriteLine();
                                Console.WriteLine("score: " + score);
                                Console.WriteLine();
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

                                if (hovedstad == false)
                                {
                                    do
                                    {
                                        score += pointSystem5;
                                        ++score;
                                    } while (hovedstad);
                                }
                                Console.WriteLine();
                                Console.WriteLine(" score: " + score);
                                Console.WriteLine();
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
                                if (jorden == false)
                                {
                                    do
                                    {
                                        score += pointSystem7;
                                        ++score;
                                    } while (jorden);
                                }
                                Console.WriteLine();
                                Console.WriteLine(" score: " + score);
                                Console.WriteLine();
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

                                if (solen == false)
                                {
                                    do
                                    {
                                        score += pointSystem9;
                                        ++score;
                                    } while (solen);
                                }
                                Console.WriteLine();
                                Console.WriteLine(" score: " + score);
                                Console.WriteLine();
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

                Console.WriteLine("");
                Console.WriteLine(" hvis du trykker enter to gange så stopper den spillet og viser din fulde score");
                Console.WriteLine("");
            } while (restaet);

            Console.WriteLine(" Så din total score er: " + score);
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
