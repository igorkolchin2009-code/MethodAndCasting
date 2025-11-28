namespace Eelarve_Arvutaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kasutajaNimi = "";
            while (kasutajaNimi == "")
            {
                Console.WriteLine("tera, sisesta oma nime;");
                kasutajaNimi = Console.ReadLine();

            }
            string sisestus = "";
            Console.WriteLine("sisesta tuled ükshaaval, kui siis kirjuta \"rohkem pole \"");
            List<float> tulud = VõtaKasutajaltMituSisenditJärjest();
            List<float> kulud = VõtaKasutajaltMituSisenditJärjest();
            
            
            if (sisestus == "" );
            {
                float kokku = 0;
                kokku = Arvutiakokku(tulud, kokku);

            }
        }

        private static float Arvutiakokku(List<float> tulud, float kokku)
        {
            for (int i = tulud.Count - 1; i >= 0; i--)
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
                Console.WriteLine("sisesta oma andmed *Üksgaaval* - järgmine tulu");
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
