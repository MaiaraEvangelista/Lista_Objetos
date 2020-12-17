using System;
using System.Collections.Generic;
using Lista_Objetos16.Classes;

namespace Lista_Objetos16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Instanciando uma lista de produtos
            Console.WriteLine("\nAcrescentação Feita: \n");
            Produto p1 = new Produto(20, "Abóbora", 19f);
            Console.WriteLine(p1.Codigo);
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine("-------------------------------------");

            //Método de Sobrecarga
            Console.WriteLine("\nSegunda parte: \n");
            Produto p2 = new Produto(30, "Abacaxi", 20f);
            Console.WriteLine(p2.Codigo);
            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Preco);
            Console.WriteLine("-------------------------------------");

            List<Produto> produtos = new List<Produto>();
            Console.WriteLine("\nApresentação da Lista: \n");
            Produto[] arrayProdutos = {};
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Match", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.87f));
            produtos.Add(new Produto(4, "Samsung", 2522.87f));
            produtos.Add(new Produto(80, "Motorola G8", 2522.87f));
        
            //Adicionando um novo produto 
            Produto p3 = new Produto();
            p3.Codigo = 91;
            p3.Nome = "Iphone XII";
            p3.Preco = 8673.87f;

            produtos.Add(p3);

            foreach (Produto item in produtos)
            {
                Console.WriteLine(item.Nome);
            }

            //Serve para remover qualquer item desejado
            Console.WriteLine("-----------------------------------");
            produtos.RemoveAt(3);
            Console.WriteLine("\nPrimeira Remoção Feita: \n");
            foreach (Produto item in produtos)
            {
                Console.WriteLine(item.Nome);
            }
          
            //Remove todos os items que possuam o código igual a 80
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\nSegunda Remoção Feita: \n ");
            
            produtos.RemoveAll(x => x.Codigo == 80);
             foreach (Produto item in produtos)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}
