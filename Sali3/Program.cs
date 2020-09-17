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
            Jasen jasen = new Jasen("Mika", "Vainio", "Ylänteentie 146", "23100", "Mynämäki", "123", "1");

            // Testataan Trainer-olion muodostimen toiminta. huom. nimiavaruus Henkilosto
            Henkilosto.Trainer trainer = new Henkilosto.Trainer("Jakke", "Jäynä", "Kotikatu 2", "21200", "Raisio", "Juoksumatto", "0447057425", "jakke.jayna@huuhaa.com");

            // Testataan Punnitus-olion toimintaa
            Punnitus punnitus = new Punnitus("10.9.2020", "70,5", "1,71");

            // Testataan Rasvaprosentti-olion toimintaa
            Rasvaprosentti rasvaprosentti = new Rasvaprosentti();

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
            Console.WriteLine("Testi trainer muodostimelle");
            trainer.naytaTrainer();
            Console.WriteLine();
            Console.WriteLine("Testi punnitus muodostimelle");
            punnitus.naytaPunnitus();
            Console.WriteLine("Painoindeksi (BMI-metodi) on " + punnitus.BMI());
            Console.WriteLine();
            Console.WriteLine("Oletustiedot rasvaprosentin laskentaan ovat:");
            Console.WriteLine("Alkuperäinen sukupuoli on: " + rasvaprosentti.Sukupuoli);
            Console.WriteLine("Alkuperäinen ikä on: " + rasvaprosentti.Ika);
            Console.WriteLine();

            // Tehdään muutokset ominaisuuksiin            
            rasvaprosentti.Ika = "58";
            rasvaprosentti.Sukupuoli = "Mies";
            Console.WriteLine("Ominaisuuksia on muutetu, uudet arvot ovat");
            Console.WriteLine("Ikä on nyt " + rasvaprosentti.Ika);
            Console.WriteLine("Sukupuoli on nyt " + rasvaprosentti.Sukupuoli);

            //Testataan rasvaprosenttilaskinta
            Console.WriteLine("Rasvaprosentti on " + rasvaprosentti.laskeRasva(1.71F, 71.5F));
            Console.WriteLine();

            //Testataan naisen rasvaprosentinlaskenta
            Rasvaprosentti nainen = new Rasvaprosentti("Nainen","35");
            Console.WriteLine("Naisen rasvaprosentti on " + nainen.laskeRasva(1.6f, 59f));
            Console.WriteLine();

            //Testataan staattista rasvaprosenttimetodia
            Console.WriteLine("Rasvaprosentti: " + Rasvaprosentti.laskeRasva2(71.5F, 1.71F, 58F, "Mies"));
            Console.WriteLine();

        }
    }
}
