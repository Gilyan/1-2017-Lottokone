/* **************************************
Taulukkoharjoitus.cs

Luotu 9.1.2017
Muokattu 10.1.2017

Toiminta: Kysyy käyttäjältä viisi käyttäjänimeä ja tallentaa ne taulukkoon.
Tulostetaan nimet ruudulle aakkosjärjestyksessä.

Minttu Mäkäläinen K8517
************************************** */

using System;                               // Sovellus käyttää System nimiavaruutta, sisältää C#:n perusluokkia - LAITA AAKKOSJÄRJESTYKSEEN

namespace Hello                             // Määrittelee tämän sovelluksen nimiavaruuden
{
    class Testi                             // Määrittelee sovelluksen pääluokan. Pitää olla yksikkömuodossa oleva substantiivi.
    {
        static void Main(string[] args)     // Näitä saa olla vain yksi!
        {
            string[] nimet = new string[5];         // Merkkijonotaulukko esitellään ja alustetaan

            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine("Anna nimi: ");
                nimet[i] = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("Annetut nimet olivat: ");
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.Write(nimet[i] + " ");
            }

            Array.Sort(nimet);

            Console.WriteLine("\n\nAnnetut nimet aakkosjärjestyksessä:");

            for (int i = 0; i <= 4; i++)
            {
                Console.Write(nimet[i] + " ");
            }

            Console.WriteLine("\n");
        }
    }
}

