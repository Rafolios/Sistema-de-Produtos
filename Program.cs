using System;

namespace produto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            float[] preço = new float [10];
            bool[] promoção = new bool[10];

            bool breakloop = false;
            bool condição = true;

            int produtos;

            do {

            MostrarMenu();

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Quantos produtos quer cadastrar? (máximo de 10)");
                    produtos = int.Parse(Console.ReadLine());

                    do
                    {
                        Cadastrarproduto();
                    
                }while (breakloop == false);


                    break;

                case 2:

                        ListarProdutos();

                    break;

                case 0:
                    Console.WriteLine("Obrigado por utilizar nosso serviço!");
                    condição = false;
                    break;
            }
            }while(condição == true);
            
            void Cadastrarproduto() {

                for (var i = 0; i < produtos; i++)
                    {
                        Console.WriteLine("Qual é o nome do produto?");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine("Qual é o preço desse produto?");
                        preço[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("Este produto está em promoção?");
                        promoção[i] = bool.Parse(Console.ReadLine());
                        Console.WriteLine("Cadastrado Produto número: " + i);
                    }

                    Console.WriteLine("Deseja cadastrar outro produto? s/n");
                    string choice = Console.ReadLine();

                    if (choice == "s")
                    {
                        breakloop = false;

                    } else if (choice == "n") {
                        breakloop = true;
                    }
            }

            void ListarProdutos() {

                Console.Clear();

                    Console.WriteLine($"Produto         Preço        Desconto?");
                    for (var i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"{nome[i]}       {preço[i]}      {promoção[i]}");
                    }
            }

            void MostrarMenu() {

                Console.WriteLine($@"
            |================================|
            |                                |
            |              MENU              |
            |                                |
            |================================|
            |                                |
            |      1-Cadastrar Produto       |
            |      2-Listar Produtos         |
            |      0-Sair                    |
            |                                |
            |================================|");
            }

        }
    }
}
