using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sali3
{
    class Rasvaprosentti
    {

        //Staattinen metodi iän laskemiseksi
        static public int Ika(string syntymapaiva)
        {
            CultureInfo cultureInfo = new CultureInfo("fi-FI");
            DateTime vuosinolla = new DateTime(1, 1, 1);
            DateTime spaiva = DateTime.Parse(syntymapaiva, cultureInfo);
            DateTime tanaan = DateTime.Now;
            TimeSpan ero = tanaan - spaiva;
            int ika = (vuosinolla + ero).Year - 1;
            return ika;

        }
        //Staattinen metodi painoindeksin laskemiseksi
        static public float BMI(string pituus, string paino)
        {
            // Muutetaan olion merkkijono-ominaisuudet liukuluvuiksi (float)
            float painoKg = float.Parse(paino);
            float pituusM = float.Parse(pituus);

            // Lasketaan painoindeksi ja palautetaan se
            float bmi = painoKg / (pituusM * pituusM);
            return bmi;
        }
        //Staattinen metodi, jolla rasvaprosentti voidaan laskea ilman oliota
        static public float laskeRasva2(float bmi, int ika, string sukupuoli)
        {
            
            
            float sukupuolikerroin = 0;
            sukupuoli = sukupuoli.ToLower();
            if (sukupuoli == "mies")
            {
                sukupuolikerroin = 1;
            }
            if (ika < 16)
            {
                float rasva = (1.51f * bmi) - (0.70F * ika) - (3.6F * sukupuolikerroin) + 1.4f;
                return rasva;
            }
            else
            {
                float rasva = (1.2F * bmi) + (0.23F * ika) - (10.8F * sukupuolikerroin) - 5.4f;
                return rasva;
            }
            
            
        }
    }
}