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
        List<Produto> estoque = new List<Produto>();

        do
        {
            Console.WriteLine("\n1 - Cadastro de Produto");
            Console.WriteLine("2 - Consulta de Produto");
            Console.WriteLine("3 - Listar Estoque");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProduto(estoque);
                    break;

                case "2":
                    ConsultarProduto(estoque);
                    break;

                case "3":
                    ListarEstoque(estoque);
                    break;

                case "4":
                    Console.WriteLine("Saindo do programa.");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (true);
    }

    static void CadastrarProduto(List<Produto> estoque)
    {
        try
        {
            Console.WriteLine("\nCadastro de Produto:");

            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            decimal precoUnitario = decimal.Parse(Console.ReadLine());

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
    }

    static void ConsultarProduto(List<Produto> estoque)
    {
        try
        {
            Console.Write("\nConsulta de Produto - Digite o Código: ");
            int codigoConsulta = int.Parse(Console.ReadLine());

            Produto produtoConsultado = BuscarProdutoPorCodigo(estoque, codigoConsulta);

            Console.WriteLine($"Produto encontrado - Código: {produtoConsultado.Codigo}, Nome: {produtoConsultado.Nome}, Quantidade: {produtoConsultado.Quantidade}, Preço Unitário: {produtoConsultado.PrecoUnitario:C}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato inválido. Certifique-se de inserir um valor numérico para o Código.");
        }
        catch (ProdutoNaoEncontradoException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void ListarEstoque(List<Produto> estoque)
    {
        Console.WriteLine("\nEstoque Atual:");
        foreach (var produto in estoque)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço Unitário: {produto.PrecoUnitario:C}");
        }
    }

    static Produto BuscarProdutoPorCodigo(List<Produto> estoque, int codigo)
    {
        Produto produtoEncontrado = estoque.Find(produto => produto.Codigo == codigo);

        if (produtoEncontrado == null)
        {
            throw new ProdutoNaoEncontradoException($"Produto com código {codigo} não encontrado.");
        }

        return produtoEncontrado;
    }
}

public class ProdutoNaoEncontradoException : Exception
{
    public ProdutoNaoEncontradoException(string mensagem) : base(mensagem)
    {
    }
}

