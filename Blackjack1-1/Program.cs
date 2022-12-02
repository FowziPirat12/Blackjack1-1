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



                    Console.WriteLine("Nu kommer två kort att dras");


                    Console.WriteLine("Din poäng:"  + (Spelare + Spelare2 ));


                    Console.WriteLine("Datorns poäng:" + slump.Next(1, 11));


                    Console.WriteLine("Vill du dra ett till kort? (j/n)");


                    break;


                case 2:


                    Console.WriteLine();


                    break;


                case 3:


                    


                    break;
                        



                case 4:


                    Console.WriteLine("Programmet har avslutats");


                    break;


            }


        }


    }


}



