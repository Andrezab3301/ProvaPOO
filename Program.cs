using System;
using System.Globalization;

namespace Course
{
    class Program{
        static void Main(string [] args){
            veiculo v = new veiculo(455, 67, "Leve", "Garagem", "Tanque cheio", 0.0);
            veiculo v2 = new veiculo(112, 877, "pesado", "Circulando", "Metade do tanque", 60.5);
            
            Console.WriteLine("Adicione um veiculo");

            Console.Write("Posicao Y: ");
            v._posicaoy = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Posicao X: ");
            v._posicaox = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Classificacão: ");
            v._clasificacao = Console.ReadLine();

            Console.Write("Situcão: ");
            v._situacao = Console.ReadLine();

            Console.Write("Combustivel: ");
            v._combustivel = Console.ReadLine();

            Console.Write("Velocidade: ");
            v._velocidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("DADOS DO VEICULO ADICIONADO");
            Console.WriteLine(v.RetornaClasificacao());
            Console.WriteLine(v.RetornaSituacao());
            Console.WriteLine(v.RetornaCombustivel());
            Console.WriteLine(v.RetornaVelocidade());

            Console.WriteLine(v2);
        }
    }
}