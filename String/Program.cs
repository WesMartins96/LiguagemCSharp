using System;
using System.Reflection.Metadata;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";
            Console.WriteLine("Original:  -" + original + "-");

            //converter para maiusculo
            string s1 = original.ToUpper();
            Console.WriteLine("ToUpper: -" + s1 + "-");

            //converter para minusculo
            string s2 = original.ToLower();
            Console.WriteLine("ToLower: -" + s2 + "-");

            //Apagar os espaços em branco no inicio e no final da string
            string s3 = original.Trim();
            Console.WriteLine("Trim: -" + s3 + "-");

            //Procurar na string, e retorna o primeiro index (posição) da ocorrencia
            int n1 = original.IndexOf("bc");
            Console.WriteLine("IndexOf(bc): -" + n1 + "-");

            //Procurar na string, e retorna a última index (posição) da ocorrencia
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("LasIndexOf(bc): -" + n2 + "-");

            //Recortar uma string, usando o indice inicial e o tamanho que quer cortar
            string s4 = original.Substring(3);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            string s5 = original.Substring(3, 5);
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");

            //Substituir uma string ou caracter por outra.
            //exemplo: trocar todo char a por x
            string s6 = original.Replace('a', 'x');
            Console.WriteLine("Replace(a, x): -" + s6 + "-");

            //exemplo: trocar todo string abc por xy
            string s7 = original.Replace("abc", "xy");
            Console.WriteLine("Replace(abc, xy): -" + s7 + "-");

            //Testar se a string é vazia
            bool b1 = string.IsNullOrEmpty(original);
            Console.WriteLine("IsNullOrEmpty(original): "+ b1);


            //ótimo para verificação de formulario
            //Testar se a string é nula ou se é umonte de espaço em branco
            bool b2 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine("IsNullOrWhiteSpace(original): " + b2);



        }
    }
}
