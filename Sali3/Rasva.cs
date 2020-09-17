using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Rasvaprosentti
    {
        // Määritellään kentät (field), huom. nimi pienellä
        protected string sukupuoli;
        protected string ika;

        // Samat tiedot ominaisuuksina (property), huom nimi isolla
        public string Sukupuoli
        {
            get
            { return sukupuoli; }
            set
            { sukupuoli = value; }
        }

        public string Ika
        {
            get
            { return ika; }
            set
            { ika = value; }
        }

        // Sama voitaisiin tehdä lyhyemmin
        public string Vuotta { get; set; }
        public string Spuoli { get; set; }

        // Ominaisuus voidaan myös tehdä sellaiseksi, että sitä voi vain lukea, muttei muuttaa
        public string VuottaVanha { get; }

        // Ominaisuus voidaan myös määritellä vain muokattavaksi
        public string Sukup { get; set; }

        // Oletusmuodostin
        public Rasvaprosentti()
        {
            this.sukupuoli = "Nainen";
            this.ika = "0";
        }

        //Muodostin kaikilla parametreillä
        public Rasvaprosentti(string sukupuoli, string ika)
        {
            this.sukupuoli = sukupuoli;
            this.ika = ika;
        }
        public float laskeRasva(float pituus, float paino)
        {
            float bmi = paino / (pituus * pituus);        
            float sukupuolikerroin = 0;
            if (this.sukupuoli == "Mies")
                {
                sukupuolikerroin = 1;
                }

            float rasva = (1.2F * bmi) + (0.23F * float.Parse(this.ika)) - (10.8F * sukupuolikerroin) - 5.4F;
            return rasva;
        }
       //Staattinen metodi, jolla rasvaprosentti voidaan laskea ilman oliota
        static public float laskeRasva2(float paino, float pituus, float ika, string sukupuoli)
        {
            float bmi = paino / (pituus * pituus);
            float sukupuolikerroin = 0;
            sukupuoli = sukupuoli.ToLower();
            if (sukupuoli == "mies")
            {
                sukupuolikerroin = 1;
            }
            float rasva = (1.2F * bmi) + (0.23F * ika) - (10.8F * sukupuolikerroin) -5.4f;
            return rasva;

        }
    }
}