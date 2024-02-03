using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistrerare
{
    internal class Person
    {
        // Jag har valt att göra parametrar privata, och hämta/skrive genom metoder/initialisering endast
        private string _förnamn;
        private string _efternamn;
        private string _personnummer;
        private string _kön;

        public Person(string förnamn, string efternamn, string personnummer)
        {
            // Vid initialisering får personen sin information, personnumret kontrolleras (lämnas tom om det inte har gått igenom kontroll
            // Vi letar också efter personens kön baserat på personnummer
            _förnamn = förnamn;
            _efternamn = efternamn;
            _personnummer = ValideraPersonnummer(personnummer) ? personnummer : string.Empty;
            _kön = HittaKön(personnummer);
        }
        // Metoden ReturneraData är den vi använder för att få information om en person.
        // Man kan ju såklart även returnera data vid initialisering men jag valde att lägga den som en egen metod
        public List<string> ReturneraData()
        {
            return new List<string>() { _förnamn, _efternamn, _personnummer, _kön};
        }
        // Metoden HittaKön räknar ut om det är en kvinna eller man, beroende på om det näst sista talet är jämt eller ej. 
        // Den returnerar helt enkelt en tom sträng om den av någon anledning inte kunde konvertera talet vid positionen till en int
        public static string HittaKön(string personnummer)
        {
            try
            {
                if (Convert.ToInt16(personnummer[personnummer.Length - 2]) % 2 == 0)
                {
                    return "Kvinna";
                }
                else
                {
                    return "Man";
                }
            }
            catch
            {
                return string.Empty;
            }
        }
        // Validera personnummer använder 21-algoritm för att räkna samman en "digit sum"
        // Det görs två kontroller, först att personnummer är 10 eller 12 i längd
        // Sedan att strängen går att omvandla till en long
        // Returneras gör sedan true eller false beroende på om den klarade valideringen
        public static bool ValideraPersonnummer(string personnummer)
        {
            if (personnummer.Length == 10 || personnummer.Length == 12)
            {
                // Här kortar vi ned personnumret till 10 tecken långt (på detta vis kan vi ändå tillåta att personen skriver in 12 tecken)
                personnummer = personnummer.Length == 12 ? personnummer.Substring(2) : personnummer;
                // Vi provar att personnumret endast innehåller siffror
                if (long.TryParse(personnummer, out _))
                {
                    // Om den endast innehåller siffror tar vi här och initialiserar resultatet, samt gör om personnumret till en char array
                    // Anledningen till att göra det till en char array är så att vi kan iterera över alla siffror
                    int resultat = 0;
                    char[] personnummerChar = personnummer.ToCharArray();
                    // Här itererar vi över personnumret
                    for (int i = 0; i < personnummer.Length; i++)
                    {
                        // Om numret är jämt
                        if (i % 2 == 0)
                        {
                            // Vi konverterar nuvarande Char till int och gångrar med 2
                            // Tyvärr konverterar "get numeric value" till double
                            int beräkning = Convert.ToInt32(Char.GetNumericValue(personnummerChar[i])) * 2;
                            // Denna loop plussar på varje siffra för sig till resultatet, precis som "21-Algoritm" gör
                            while (beräkning > 0)
                            {
                                resultat += beräkning % 10;
                                beräkning = beräkning / 10;
                            }
                        }
                        else
                        {
                            // Vi konverterar nuvarande char till in och gångrar med 2.
                            // Tyvärr konverterar "get numeric value" till double
                            int beräkning = Convert.ToInt32(Char.GetNumericValue(personnummerChar[i])) * 1;
                            // Vi adderar siffran till resultatet
                            resultat += beräkning;
                        }
                    }
                    // Vi skickar tillbaka true om resultatet är jämt delbart med 10
                    return resultat % 10 == 0 ? true : false;

                }
                else return false;
            }
            else return false;
        }
    }
}
