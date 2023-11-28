using System;
using System.Collections.Generic;

public class Produto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Criando uma lista para armazenar produtos
        List<Produto> estoque = new List<Produto>();

        // Cadastro de produtos
        do
        {
            try
            {
                Console.WriteLine("\nCadastro de Produto:");

                // Solicitando informações do produto ao usuário
                Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.Write("Preço Unitário: ");
                decimal precoUnitario = decimal.Parse(Console.ReadLine());

                // Criando o objeto Produto e adicionando à lista
                Produto novoProduto = new Produto
                {
                    Codigo = codigo,
                    Nome = nome,
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario
                };

                estoque.Add(novoProduto);

                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Formato inválido. Certifique-se de inserir um valor numérico para Código, Quantidade e Preço.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            // Perguntando se o usuário deseja cadastrar outro produto
            Console.Write("Deseja cadastrar outro produto? (S/N): ");
        } while (Console.ReadLine().ToUpper() == "S");

        // Exibindo o estoque
        Console.WriteLine("\nEstoque Atual:");
        ListarEstoque(estoque);
    }

    // Função para listar o estoque
    static void ListarEstoque(List<Produto> estoque)
    {
        foreach (var produto in estoque)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço Unitário: {produto.PrecoUnitario:C}");
        }
    }
}

