namespace M_koer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage esimene arv!");
            int esimeneArv = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage teine arv!");
            int teineArv = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage tehe (+, -, *, /): ");
            string tehe = Console.ReadLine();

            double tulemus = 0;

            if (tehe == "+")
            {
                tulemus = esimeneArv + teineArv;
            }
            else if (tehe == "-")
            {
                tulemus = esimeneArv - teineArv;
            }
            else if (tehe == "*") 
            {
                tulemus = esimeneArv * teineArv;
            }
            else if (tehe == "/")
            {
                tulemus = esimeneArv / teineArv;
            }
            else
            {
                Console.WriteLine("Tulemus: " + tulemus);
            }
        }
    }
}















