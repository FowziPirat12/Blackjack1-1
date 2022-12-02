using System;

namespace BlackJack_1

{
    class program


    {
        static void Main(string[] args)


        {
            Console.WriteLine("Välkommen till 21!");
            Console.WriteLine("1. Spela 21:an");
            Console.WriteLine("2. Visa senaste vinnaren");
            Console.WriteLine("3. Spelets regler");
            Console.WriteLine("4. Avsluta Programmet");
            int val = int.Parse(Console.ReadLine());
            Random slump = new Random();

            switch (val)


            {


                case 1:

                    int Spelare = slump.Next(1, 11);
                    int Spelare2 = slump.Next(1, 11);   
                    int Dator = slump.Next(1,11);
                    int Dator2 = slump.Next(1, 11);



                    Console.WriteLine("Nu kommer två kort att dras");


                    Console.WriteLine("Din poäng:"  + (Spelare + Spelare2 ));


                    Console.WriteLine("Datorns poäng:" + (Dator + Dator2));


                    Console.WriteLine("Vill du dra ett till kort? (j/n)");


                    break;


                case 2:

                    
                    Console.WriteLine();


                    break;


                case 3:
                    string text = "Ditt mål är att tvinga datorn att få mer än 21 poäng.";
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(50);
                    }

                    Console.WriteLine("");

                    string text2 = "Du får poäng genom att dra kort, varje kort har 1-10 poäng.";
                    foreach (char e in text2)
                    {
                        Console.Write(e);
                        Thread.Sleep(50);
                    }

                    Console.WriteLine("");

                    string text3 = "Om du får mer än 21 poäng har du förlorat.";
                    foreach (char f in text3)
                    {
                        Console.Write(f);
                        Thread.Sleep(50);
                    }

                    Console.WriteLine("");

                    string text4 = "Både du och datorn får två kort i början. Du ska dra kort till du är nöjd eller får över 21";
                    foreach (char g in text4)
                    {
                        Console.Write(g);
                        Thread.Sleep(50);
                    }

                    Console.WriteLine("");

                    string text5 = "När du är färdig drar datorn kort till den har mer poäng än dig eller över 21 poäng.";
                    foreach (char h in text5)
                    {
                        Console.Write(h);
                        Thread.Sleep(50);
                    }

                    Console.WriteLine("");

                    string text6 = "Ditt mål är att tvinga datorn att få mer än 21 poäng.";
                    foreach (char i in text6)
                    {
                        Console.Write(i);
                        Thread.Sleep(50);
                    }




                    break;
                        



                case 4:


                    Console.WriteLine("Programmet har avslutats");


                    break;


            }


        }


    }


}






