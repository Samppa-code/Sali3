using System;


namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan Henkilo-olion luontia");

            /*----------------------------------------------------
             | TESTAUS ALKAA TÄSTÄ                                 |
             |---------------------------------------------------- */
            
            // Testataan oletusmuodostin

            Henkilo henkilo = new Henkilo();

            // Testataan muodostin kaikilla parametreillä

            Henkilo henkilo1 = new Henkilo("Mika", "Hakala", "Kotikatu 3", "20100", "Turku");


            // Testataan Jäsen-olion muodostimen toiminta
            Jasen jasen = new Jasen("Mika", "Vainio", "Ylänteentie 146", "23100", "Mynämäki", "123", "1" ,"26.6.1962");


            // Testataan Punnitus-olion toimintaa
            Punnitus punnitus = new Punnitus("10.9.2020", "70,5", "1,71");

            

            // Katsotaan olioiden ominaisuuksia
            Console.WriteLine("Testi oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine();
            Console.WriteLine("Testi muodostimelle kaikilla prarametreilla");
            henkilo1.naytaHenkilo();
            Console.WriteLine();
            Console.WriteLine("Testi jäsenen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("Testi punnitus muodostimelle");
            punnitus.naytaPunnitus();


            //Testi iän laskennan toimimisesta
            int vuotta = Rasvaprosentti.Ika("26.6.1962");
            Console.WriteLine("Moon " + vuotta + " vuotta vanha");

        }
    }
}
