namespace kontrolltöö05._12._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kasutajaNimi = "";
            do
            {
                Console.WriteLine("kas sinu mime on");
                kasutajaNimi = Console.ReadLine();
                if (kasutajaNimi == "")
                {
                    Console.WriteLine("");
                    break;
                }
                else if (kasutajaNimi == "Nipitiri")
                {
                    Console.WriteLine("see name ei ta pole");
                }

            }while (kasutajaNimi == "");
            int namber = 0;
            Console.WriteLine("viimase nädala mängitud tunde");
            namber = int.Parse(Console.ReadLine());

            if (namber < 0)
            {
                Console.WriteLine("kahju et sulle aega");
            }
            else if (namber < 10 && namber > 0)
            {
                Console.WriteLine("mõõdukas mängija, tubli");
            }
            else if(namber < 20 && namber > 10)
            {
                Console.WriteLine("natuke paljals läheb kodutööd kannatavad");
            }
            else if (namber < 40 && namber > 20)
            {
                Console.WriteLine("liiga palju mängud, kas sa kooli üldse nii jõuand");
            }
            else
            {
                Console.WriteLine("siin peaks juba sekkuma psühholog");
            }
            int tulemus = 0;

            while (tulemus < 1 && tulemus > 4)
            {
                tulemus = int.Parse(Console.ReadLine());
                Console.WriteLine("küsi kasutajalt tema viimast jalgpallimängi tulemust 1-4");
            }
            switch (tulemus)
            {
                case 1:
                    Console.WriteLine("täotsa ok");
                    break;
                case 2:
                    Console.WriteLine("no see juba on parem");
                    break;
                case 3:
                    Console.WriteLine("Wow, messi");
                    break;
                default:
                    Console.WriteLine("PUDRUJALG OLED VÄ!?!?!");
                    break;
            }

        }
    }
}
