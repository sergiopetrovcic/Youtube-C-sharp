namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de resistência equivalente para dois resistores em paralelo.\n");
            Console.WriteLine("Digite o valor da primeira resistência e pressione Enter.");
            int res1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor da segunda resistência e pressione Enter.");
            int res2 = Convert.ToInt16(Console.ReadLine());
            float resEqu = -1;
            if (res1 == res2) 
                resEqu = res1 / 2;
            else 
                resEqu = res1 * res2 / res1 + res2;
            Console.WriteLine("A resistência equivalente é " + resEqu.ToString() + " ohms.\n");
            Console.ReadKey();
        }
    }
}
