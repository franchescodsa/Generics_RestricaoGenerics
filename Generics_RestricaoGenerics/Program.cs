using Generics_RestricaoGenerics.Entities;
using Generics_RestricaoGenerics.Services;
using System.Globalization;

namespace Generics_RestricaoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Uma empresa de consultoria deseja avaliar a performance de produtos,
funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
o maior dentre um conjunto de elementos. Fazer um programa que leia um conjunto de N produtos  */
           List<Product> list = new List<Product>();

            Console.WriteLine("Enter N: ");
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){

                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0]; //Elemento na posição antes da vidrgula
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture); //Elemnto depois da virgula
               
                list.Add(new Product(name, price));
                
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
