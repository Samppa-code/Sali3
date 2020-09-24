using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Punnitus
    {

        // Kaikki kentät merkkijonoja, koska syöte tulee näppäimmistöstä
        protected string paiva;
        protected string paino;
        protected string pituus;

        //kenttiä vastaavat ominaisuudet (properties)
        public string Paino
        {
            get { return paino; }
        }
        public string Pituus
        {
            get { return pituus; }
        }

        //Muodostin kaikilla parametreilla
        public Punnitus(string paiva, string paino, string pituus)
        {
            this.paiva = paiva;
            this.paino = paino;
            this.pituus = pituus;
        }

        
        // Testausmetodi punnitustietojen näyttämiseen
        public void naytaPunnitus()
        {
            Console.WriteLine("Punnituspäivä: " + this.paiva);
            Console.WriteLine("Paino on: " + this.paino);
            Console.WriteLine("Pituus on: " + this.pituus);
        }
    }
}
