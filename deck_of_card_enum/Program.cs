using System;

namespace deck_of_card_enum
{
    class Program
    {
        private static readonly Random ngacax = new Random();



        static void Main(string[] args)
        {
            //            Console.WriteLine("Hello World!");

            Kartu kard = new Kartu((Values)ngacax.Next(1,14),
                                    (Suits)ngacax.Next(4));


            Console.WriteLine(kard.Name);
        } //END Main
    }
}
