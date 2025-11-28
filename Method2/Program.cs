namespace method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Tervitus();
            string kasutajaNimi = "";
            kasutajaNimi = KasutajanimeKüsimine(kasutajaNimi);
            while (kasutajaNimi == "")
            {
                Console.WriteLine("Tere, palun sisseta oma kasutajaNimi");
                kasutajaNimi = Console.ReadLine();
            }
            Console.WriteLine("Mis on sinu nädalane eelarve?");
            float eelvare = 0.00f;
            bool kaskasutajaNõustab = false;
            while (kaskasutajaNõustab == false)
            {
                Console.WriteLine($"{kasutajaNimi}m kas see on sinu õige eelarve");
                Console.WriteLine("vasta kas jah või ei");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    kaskasutajaNõustab = true;
                }
                else
                {
                    kaskasutajaNõustab= false;
                }
                
            }
        }

    }
}
