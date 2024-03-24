using System;
using System.Collections.Generic;

namespace ListII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>();

            #region Add e Insert 
            //Adicionar elementos na lista
            //Add() adiciona ao final da lista
            list.Add("Wesley");
            list.Add("Beatriz");
            list.Add("Gael");
            list.Add("Olivia");
            list.Add("Cachorro");
            list.Add("Gato");
            list.Add("Tubarão");
            list.Add("Trovão");

            //Insert podemos escolher qual a posição será inserida
            list.Insert(2, "C-sharp");
            list.Insert(3, "Bora-Bora");
            list.Insert(4, "Brasil");

            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            #endregion

            #region Count 
            //Podemos contar quantos elementos temos na lista com Count
            Console.WriteLine("List Count:" + list.Count);
            #endregion

            #region List.Find e List.FindLast 
            //exemplo: quero encontrar primeiro elemento que começa com a letra B, usando labda
            string s1 = list.Find(x => x[0] == 'B');
            Console.WriteLine("Primeiro nome que começa com B: " + s1);
            //exemplo: quero encontrar o ultimo elemento que começa com a letra B, usando lambda
            string s2 = list.FindLast(x => x[0] == 'B');
            Console.WriteLine("Ultimo nome que começa com B: " + s2);

            #endregion

            #region List.FindIndex e List.FindLastIndex 
            //primeira posição do index da lista, usando lambda
            int pos1 = list.FindIndex(x => x[0] == 'B');
            Console.WriteLine("Primeira Posição com B: " + pos1);
            //Ultima posição do index da lista, usando lambda
            int pos2 = list.FindLastIndex(x => x[0] == 'B');
            Console.WriteLine("Última posição com B: " + pos2);
            #endregion

            #region List.FindAll 
            //Para filtrar a lista: filtrar a lista é criar uma nova lista contendo os elementos que satisfaça o predicado, usando lambda.
            //exemplo: filtar apenas os nomes que contem 6 caracteres.
            List<string> filtro = list.FindAll(x => x.Length == 6);
            foreach (var obj in filtro)
            {
                Console.WriteLine("Filtrados por 6 caracteres: " + obj);
            }


            #endregion

            #region Remove, RemoveAll, RemoveAt e RemoveRange 
            //Remover elementos da lista
            list.Remove("Wesley");

            foreach (var obj in list)
            {
                Console.WriteLine("Lista Atualizada: " + obj);
            }

            //exemplo: remover todos que começam com a letra B, usando lambda.
            list.RemoveAll(x => x[0] == 'B');
            foreach (var obj in list)
            {
                Console.WriteLine("Update 2 da Lista: " + obj);
            }

            //remover um elemento pela posição dele.
            list.RemoveAt(2);
            foreach (var obj in list)
            {
                Console.WriteLine("Update 3 da lista: " + obj);
            }

            //remover elementos de uma faixa
            //exemplo: quero apartir da posição 1 excluir 2 elementos, contando com ele mesmo.
            list.RemoveRange(1, 2);

            foreach (var obj in list)
            {
                Console.WriteLine("Lista Final: " + obj);
            }
            #endregion
        }
    }
}
