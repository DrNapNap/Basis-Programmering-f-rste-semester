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
           
            string[] dwa = new string[] { "   ", "Generel viden", "    Geografi", "       Sprog", "        Historie", "       Musik" };


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

                }
                    foreach(var d in dwa)
                    Console.Write("  " + (d) + " ");
                Console.WriteLine("");


            }

        }

        static void Velkommen()
        {
            string[] myArray = new string[] { " Velkommen til Jeopardy ", " Quizmasteren placerer spillepladen med jetonerne foran sig og opstiller 6 svar/spørgsmålskort i kortholderen.      ", " Disse placeres, så spørgsmålssiden vender ind mod quizmasteren, og kategorien vender ud mod deltagerne.      ", " og kategorien vender ud mod deltagerne.       ", " Deltagerne i spillet må naturligvis ikke kunne se spørgsmål/svar-siden af kortene.       ", " Klik E for at starte " };
            string arrayStrig = myArray[0];
            string kategori = myArray[1];
            string arrayStri = myArray[2];
            string kategor = myArray[3];
            string d = myArray[4];
            string S = myArray[5];

            string tolo = arrayStrig.ToUpper();

            Console.WriteLine();
            Console.WriteLine(tolo);
            Console.WriteLine("");

            Console.WriteLine(kategori);
            Console.WriteLine(arrayStri);
            Console.WriteLine(kategor);
            Console.WriteLine(d);
            Console.WriteLine();
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



            string[] myArray = new string[] { " Skriv kategorienavn", " Skriv din kategori igen", " Du har været her før du prøver at snyde", " Skriv Hvilken sværhedsgrad", " Hvor mange tidszoner er der I Rusland?", " Skriv dit svar her" };
            string arrayStrig = myArray[0];
            string kategori = myArray[1];
            string snyde = myArray[2];
            string Hvilken = myArray[3];
                string tidsZoner = myArray[4];
            string svar = myArray[5];

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

            //Selector den bliver brugt men den er gravet ud på grund af at den først bliver brugt når den kører
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

            ///Sprog
            bool ddddasddadsa = true;
            bool dwadwadwadwawd = true;
            bool dadwawdawddw = true;
            bool dwadwadadwawdwa = true;
            bool dddddddd = true;

            //Historie


            //Musik
            bool liverpool = true;
            bool mange = true;
            bool album = true;
            bool streamede = true;
            bool angeles = true;

            // restart som der er stavet forkert
            bool restaet = false;
            do
            {


                if (restaet == true)
                {

                    Console.WriteLine(kategori);
                }


                restaet = false;

                


                selector = (Console.ReadLine());

                if (selector == "Generel viden")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine(Hvilken);

                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (tenker == false)
                    {

                        Console.WriteLine(snyde);
                    }

                    if (tenkerd == false)
                    {

                        Console.WriteLine(snyde);
                    }
                    if (tenker2 == false)
                    {

                        Console.WriteLine(snyde);
                    }
                    if (dawdwadw == false)
                    {

                        Console.WriteLine(snyde);
                    }
                    if (dddda == false)
                    {

                        Console.WriteLine(snyde);
                    }


                    if (tenker == true)
                    {
                        if (selectorSvorhedsGrad == 100)
                        {
                            Console.WriteLine(tidsZoner);
                            Console.WriteLine("");
                            Console.WriteLine(svar);
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
                            Console.WriteLine(svar);

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
                            Console.WriteLine(svar);
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
                            Console.WriteLine(svar);
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
                            Console.WriteLine(svar);
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


                ////Musik
                if (selector == "Musik")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine(" Skriv Hvilken sværhedsgrad");
                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (angeles == false)
                    {
                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }

                    if (angeles == true)
                    {
                        if (selectorSvorhedsGrad == 100)
                        {
                            Console.WriteLine(" Hvor er Billie Eilish fra?");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string verden;
                            verden = (Console.ReadLine());



                            if (verden == "Los Angeles" || verden == "los angeles")
                            {

                                Console.WriteLine(" Tillykke du har vundet 100 point");
                                angeles = false;

                                if (angeles == false)
                                {
                                    do
                                    {
                                        score += pointSystem1;
                                        ++score;
                                    } while (angeles);
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
                    
                    if (liverpool == true)
                    {
                        if (selectorSvorhedsGrad == 300)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvilken by kommer The Beatles fra? ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string vatikanstaten;

                            vatikanstaten = (Console.ReadLine());



                            if (vatikanstaten == "Liverpool" || vatikanstaten == "liverpool")
                            {

                                Console.WriteLine(" Tillykke du har vundet 300 point");
                                liverpool = false;


                                if (liverpool == false)
                                {
                                    do
                                    {
                                        score += pointSystem3;
                                        ++score;
                                    } while (liverpool);
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
                   
                    if (streamede == true)
                    {
                        if (selectorSvorhedsGrad == 500)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvad er dem mest streamede sang på Spotify ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string amerikanske;

                            amerikanske = (Console.ReadLine());



                            if (amerikanske == "Ed Sheeran" || amerikanske == "The Shape of You")
                            {

                                Console.WriteLine(" Tillykke du har vundet 500 point");
                                streamede = false;

                                if (streamede == false)
                                {
                                    do
                                    {
                                        score += pointSystem5;
                                        ++score;
                                    } while (streamede);
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

                    
                    if (album == true)
                    {
                        if (selectorSvorhedsGrad == 700)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvad var det mest streamede album på Spotify i 2019 ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string skriget;

                            skriget = (Console.ReadLine());



                            if (skriget == "When We Fall Asleep, Where Do We Go? Billie Eilish")
                            {

                                Console.WriteLine(" Tillykke du har vundet 700 point");
                                album = false;
                                if (album == false)
                                {
                                    do
                                    {
                                        score += pointSystem7;
                                        ++score;
                                    } while (album);
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

                    
                    else if (mange == true)
                    {
                        if (selectorSvorhedsGrad == 900)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvor mange tangenter har et klassisk klaver?");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string michelangelo;

                            michelangelo = (Console.ReadLine());



                            if (michelangelo == "88")
                            {

                                Console.WriteLine(" Tillykke du har vundet 900 point");
                                mange = false;

                                if (mange == false)
                                {
                                    do
                                    {
                                        score += pointSystem9;
                                        ++score;
                                    } while (ddddasddadsa);
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

                    restaet = true;

                }

                if (selector == "Historie")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine(" Skriv Hvilken sværhedsgrad");
                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (dwadwadwadwawd == false)
                    {
                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }

                    if (dwadwadwadwawd == true)
                    {
                        if (selectorSvorhedsGrad == 100)
                        {
                            Console.WriteLine(" Hvornår åbnede undergrundbanen i London?");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string verden;
                            verden = (Console.ReadLine());



                            if (verden == "1863")
                            {

                                Console.WriteLine(" Tillykke du har vundet 100 point");
                                dwadwadwadwawd = false;

                                if (dwadwadwadwawd == false)
                                {
                                    do
                                    {
                                        score += pointSystem1;
                                        ++score;
                                    } while (dwadwadwadwawd);
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

                    if (dadwawdawddw == true)
                    {
                        if (selectorSvorhedsGrad == 300)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvem opfandt internettet, og hvornår? ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string vatikanstaten;

                            vatikanstaten = (Console.ReadLine());



                            if (vatikanstaten == "tim Berners-Lee" || vatikanstaten == "1990")
                            {

                                Console.WriteLine(" Tillykke du har vundet 300 point");
                                dadwawdawddw = false;


                                if (dadwawdawddw == false)
                                {
                                    do
                                    {
                                        score += pointSystem3;
                                        ++score;
                                    } while (dadwawdawddw);
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

                    if (dwadwadadwawdwa == true)
                    {
                        if (selectorSvorhedsGrad == 500)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvem opfandt den ikoniske ”lille sorte kjole” ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string amerikanske;

                            amerikanske = (Console.ReadLine());



                            if (amerikanske == "Coco Chanel" || amerikanske == "1920")
                            {

                                Console.WriteLine(" Tillykke du har vundet 500 point");
                                dwadwadadwawdwa = false;

                                if (dwadwadadwawdwa == false)
                                {
                                    do
                                    {
                                        score += pointSystem5;
                                        ++score;
                                    } while (dwadwadadwawdwa);
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


                    if (dddddddd == true)
                    {
                        if (selectorSvorhedsGrad == 700)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvad skete der d. 20 Juli 1969 ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string skriget;

                            skriget = (Console.ReadLine());



                            if (skriget == "Apollo 11 landede på månen")
                            {

                                Console.WriteLine(" Tillykke du har vundet 700 point");
                                dddddddd = false;
                                if (dddddddd == false)
                                {
                                    do
                                    {
                                        score += pointSystem7;
                                        ++score;
                                    } while (dddddddd);
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


                    else if (ddddasddadsa == true)
                    {
                        if (selectorSvorhedsGrad == 900)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvornår blev Vogue udgivet for første gang 1892, 1960, 2000?");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string michelangelo;

                            michelangelo = (Console.ReadLine());



                            if (michelangelo == "1892")
                            {

                                Console.WriteLine(" Tillykke du har vundet 900 point");
                                ddddasddadsa = false;

                                if (ddddasddadsa == false)
                                {
                                    do
                                    {
                                        score += pointSystem9;
                                        ++score;
                                    } while (ddddasddadsa);
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

                    restaet = true;

                }



                ///---------------
                if (selector == "Sprog")
                {
                    int selectorSvorhedsGrad;
                    Console.WriteLine(" Skriv Hvilken sværhedsgrad");
                    selectorSvorhedsGrad = int.Parse((Console.ReadLine()));

                    if (dwadwadwadwawd == false)
                    {
                        Console.WriteLine(" du har været her før du prøver at snyde");
                    }

                    if (dwadwadwadwawd == true)
                    {
                        if (selectorSvorhedsGrad == 100)
                        {
                            Console.WriteLine(" Hvad er slang navnet for New York som de lokale bruger?");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string verden;
                            verden = (Console.ReadLine());



                            if (verden == "Gotham" || verden == "gotham")
                            {

                                Console.WriteLine(" Tillykke du har vundet 100 point");
                                dwadwadwadwawd = false;

                                if (dwadwadwadwawd == false)
                                {
                                    do
                                    {
                                        score += pointSystem1;
                                        ++score;
                                    } while (dwadwadwadwawd);
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
                    
                    if (dadwawdawddw == true)
                    {
                        if (selectorSvorhedsGrad == 300)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvilken bogserie solgte mest i det 21ende århundrede? ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string vatikanstaten;

                            vatikanstaten = (Console.ReadLine());



                            if (vatikanstaten == "Harry Potter" || vatikanstaten == "J. K. Rowling")
                            {

                                Console.WriteLine(" Tillykke du har vundet 300 point");
                                dadwawdawddw = false;


                                if (dadwawdawddw == false)
                                {
                                    do
                                    {
                                        score += pointSystem3;
                                        ++score;
                                    } while (dadwawdawddw);
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
                    
                    if (dwadwadadwawdwa == true)
                    {
                        if (selectorSvorhedsGrad == 500)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvilken kendt grafitti kunstner kommer fra Bristol? ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string amerikanske;

                            amerikanske = (Console.ReadLine());



                            if (amerikanske == "Banksy" || amerikanske == "banksy")
                            {

                                Console.WriteLine(" Tillykke du har vundet 500 point");
                                dwadwadadwawdwa = false;

                                if (dwadwadadwawdwa == false)
                                {
                                    do
                                    {
                                        score += pointSystem5;
                                        ++score;
                                    } while (dwadwadadwawdwa);
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

                    
                    if (dddddddd == true)
                    {
                        if (selectorSvorhedsGrad == 700)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Den norske kunstner Edvard Munch er kendt for at male hvilket ikonisk maleri? ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string skriget;

                            skriget = (Console.ReadLine());



                            if (skriget == "Skriget" || skriget == "Skriget")
                            {

                                Console.WriteLine(" Tillykke du har vundet 700 point");
                                dddddddd = false;
                                if (dddddddd == false)
                                {
                                    do
                                    {
                                        score += pointSystem7;
                                        ++score;
                                    } while (dddddddd);
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

                    
                    else if (ddddasddadsa == true)
                    {
                        if (selectorSvorhedsGrad == 900)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Hvilken kunstner malede loftet i Det Sixtinske Kapel i Rom? ");
                            Console.WriteLine("");
                            Console.WriteLine(svar);
                            string michelangelo;

                            michelangelo = (Console.ReadLine());



                            if (michelangelo == "Michelangelo" || michelangelo == "michelangelo")
                            {

                                Console.WriteLine(" Tillykke du har vundet 900 point");
                                ddddasddadsa = false;

                                if (ddddasddadsa == false)
                                {
                                    do
                                    {
                                        score += pointSystem9;
                                        ++score;
                                    } while (ddddasddadsa);
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

                    restaet = true;

                }
               // --------

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
                            Console.WriteLine(svar);
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
                            Console.WriteLine(svar);
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
                            Console.WriteLine(svar);
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
                            Console.WriteLine(svar);
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
                            Console.WriteLine(svar);
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
               
                        
                    
                }


             

                restaet = true;
            } while (restaet);

            Console.WriteLine(" Så din total score er: " + score);
            return selector;
        }



        static void h1()
        {



            string s = "   ==============" + " Jeopardy " + "==============";



            string toUpper = s.ToUpper();

            Console.SetCursorPosition((Console.WindowWidth - toUpper.Length) / 3, Console.CursorTop + 2);




            Console.WriteLine(toUpper);

        }


    }
}
