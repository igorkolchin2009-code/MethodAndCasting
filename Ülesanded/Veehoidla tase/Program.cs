
namespace Veehoidla_tase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kasutajaNimi = KasutajaNimi();

            string correstUser = "siksseven";
            if (kasutajaNimi != correstUser)
            {
                Console.WriteLine(kasutajaNimi+", Sinu nime ei ole õige");
            }
            else
            {
                double veetase = 0d;
                Console.WriteLine("Tere, "+ correstUser+ ". Mis on veetaseme hetkeseis meetrites?: ");
                bool errorState = false;
                do
                {
                    Console.WriteLine("Mis on veetase andurul?:");
                    double andyr = double.Parse(Console.ReadLine());
                    veetase = andyr;
                    if (veetase < 1.00d || veetase > 4.25d)
                    {
                        errorState = true;
                        break;

                    }
                    
                } while (veetase < 1.00d && veetase > 4.25d);
                HoiatySõna(veetase, errorState);


            }

        }

        private static void HoiatySõna(double veetase, bool errorState)
        {
            //throw new NotImplementedException();
            if (veetase >= 1.00d && veetase < 2.00d )
            {
                Console.WriteLine("Veetase on madal");
            }
            else if (veetase >= 2.00d && veetase < 3.50d )
            {
                Console.WriteLine("veetase on normaalne Paanikaks ei ole Põhust!!!!");
            }
            else if (veetase >= 3.50d && veetase < 4.25d )
            {
                Console.WriteLine("tase on liiga kõrge kõrge, chill");
            }
            else
            {
                errorState = true;
                Console.WriteLine("* anduri viga, kontrolli seadet *");
            }
        }

        private static string KasutajaNimi()
        {
            string sisusta = "";
            do
            {
                Console.WriteLine("Palun sisesta oma kasutajaNimi");
                sisusta = Console.ReadLine();
            } while (sisusta == "");
            return sisusta;
        }
    }
}
