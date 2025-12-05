namespace Eelarve_Arvutaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt tema nime (tsüklis)
            string kasutajaNimi = "";
            while (kasutajaNimi == "")
            {
                Console.WriteLine("Tere, sisesta oma nimi:");
                kasutajaNimi = Console.ReadLine();
            }

            //küsi kasutajalt tema tulusid, niikaua kuni rohkem pole
            //siis küsi kasutajalt tema kulusid, ka niikaua kuni rohkem pole.
            //hoia andmeid List tüüpi muutujas, andmed ise peavad olema komakohaga.
            string sisestus = "";
            Console.WriteLine("Sisesta tulud ükshaaval, kui on kõik, siis kirjuta \"rohkem pole\"");
            List<float> tulud = VõtaKasutajaltMituSisenditJärjest();
            Console.WriteLine("Sisesta  oma kulud ükshaaval, kui on kõik, siis kirjuta \"rohkem pole\"");
            List<float> kulud = VõtaKasutajaltMituSisenditJärjest();

            //tee uus meetod, mis arvutab kokku järjendi sisu

            float tuludkokku = 0;
            tuludkokku = ArvutaKokku(tulud);
            float kuludkokku = ArvutaKokku(tulud);

            //hoia kogutulusid ja kogukulusid eraldi muutujates kasutades oma meetodit.

            //arvuta kasutajale tulude ja kulude põhjal tema hetkeseis.
            float kokku = (float)Math.Round((tuludkokku - kuludkokku), 2);

            //Ümarda kasutajale tagastatav arv kahe komakohani. Ja kuva nimeline sõnum
            Console.WriteLine($" kasutaja: {kasutajaNimi}, teie kontoseis on: {kokku}");
        }

        private static float ArvutaKokku(List<float> tulud)
        {
            float kokku = 0;
            for (int i = 0; i < tulud.Count; i++)
            {
                kokku += tulud[i];
            }

            return kokku;
        }

        private static List<float> VõtaKasutajaltMituSisenditJärjest()  
        {
            List<float> tulud = new List<float>();
            string sisestus;
            do
            {
                Console.WriteLine("Sisesta oma andmed *ÜKSHAAVAL* - järgmine sisestus:");
                sisestus = Console.ReadLine();
                if (sisestus == "rohkem pole")
                {
                    break;
                }
                float conversion = float.Parse(sisestus);
                tulud.Add(conversion);
            } while (sisestus != "rohkem pole");
            return tulud;
        }
    }
}