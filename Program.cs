using System.Globalization;
namespace Exercicio2_udemy
{
    public class Exercicio2_udemy
    {
        static void Main()
        {
            int cod1, cod2, qnt1, qnt2;
            double valor1, valor2, valorTotal;

            string[] v = Console.ReadLine().Split(' ');
            cod1 = int.Parse(v[0]);
            qnt1 = int.Parse(v[1], CultureInfo.InvariantCulture);
            valor1 = double.Parse(v[2], CultureInfo.InvariantCulture);
            cod2 = int.Parse(v[3]);
            qnt2 = int.Parse(v[4], CultureInfo.InvariantCulture);
            valor2 = double.Parse(v[5], CultureInfo.InvariantCulture);

            valorTotal = (qnt1 * valor1) + (qnt2 * valor2);

            System.Console.WriteLine("VALOR A PAGAR : R$ "+ valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}