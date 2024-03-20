using System;
using System.Globalization;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cultura = CultureInfo.InvariantCulture;

            string frase = Console.ReadLine();
            Console.WriteLine($"Você digitou: {frase}");

            string x = Console.ReadLine();
            Console.WriteLine($"Você digitou: {x}");
            string y = Console.ReadLine();
            Console.WriteLine($"Você digitou: {y}");
            string z = Console.ReadLine();
            Console.WriteLine($"Você digitou: {z}");


            //Split -> guardar palavras diferentes da mesma frase porem em variaveis diferentes;
            //console: "batata tomate abacaxi"
            //result: p1 = batata, p2 = tomate, p3 = abacaxi;
            Console.WriteLine("--- usando Split ---");
            string s = "batata tomate abacaxi";
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


            Console.WriteLine("--- Desafio ---");
            string cores = "Amarelo Laranja Cinza";
            string[] vCores = cores.Split(" ");
            string amarelo = vCores[0];
            string laranja = vCores[1];
            string cinza = vCores[2];
            Console.WriteLine(amarelo);
            Console.WriteLine(laranja);
            Console.WriteLine(cinza);

            Console.WriteLine("--- Aula parteII ---");

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + n1);
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + ch);
            float n2 = float.Parse(Console.ReadLine(), cultura);
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(cultura));


            Console.WriteLine("--- Ler dados e converter após realizar o split ---");
            //Ler os dados de entrada e "splitar" para diferentes variaveis.
            string[] dados = Console.ReadLine().Split(" ");
            string nome = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], cultura);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(cultura));

        }
    }
}
