/* **************************************
Hello.cs

Luotu 9.1.2017

Toiminta: Tulostaa näytölle tekstiä eri tavoin. Harjoiteltu olion luontia.

Minttu Mäkäläinen K8517
************************************** */

using System;                               // Sovellus käyttää System nimiavaruutta, sisältää C#:n perusluokkia - LAITA AAKKOSJÄRJESTYKSEEN

namespace Hello                             // Määrittelee tämän sovelluksen nimiavaruuden
{
    class Henkilo                           // Luokka = Henkilo
    {
        public string Nimi { get; set; }    // Ominaisuus = Nimi. Get = voidaan lukea. Set = voidaan asettaa.
        public int Ika { get; set; }        // Ominaisuus = Ika.
    }
    class Testi                             // Määrittelee sovelluksen pääluokan. Pitää olla yksikkömuodossa oleva substantiivi.
    {
        static void Main(string[] args)     // Näitä saa olla vain yksi!
        {
            string nimi = "Robert Jordan";          // Määritellään muuttuja
            Console.WriteLine("Terve " + nimi);     // Tulostetaan näytölle muuttujan sisältö.

            Henkilo hlo = new Henkilo();            // Luodaan olio Henkilo-luokasta
            hlo.Nimi = "Terry Pratchett";
            hlo.Ika = 66;
            Console.WriteLine("Terve {0}, ikäsi on {1}.", hlo.Nimi, hlo.Ika); // Tulostetaan näytölle olion hlo ominaisuuksia. Käytetty kapselointia.

            Console.ReadLine();                     // Pidetään sovelluksen ajoikkuna auki. Sulkeutuu enteristä. Ei välttämättä ole tarpeen.
        }
    }
}