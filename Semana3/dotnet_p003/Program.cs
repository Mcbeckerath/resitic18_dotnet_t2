using System;

public class Produto {
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
}

public class Program {
    public static void Main(string[] args) {
        Produto produto = new Produto()
        {
            Codigo = 123456,
            Nome = "Caneta",
            Quantidade = 100,
            PrecoUnitario = 10,
        };

        Console.WriteLine("Código: " + produto.Codigo);
        Console.WriteLine("Nome: " + produto.Nome);
        Console.WriteLine("Quantidade: " + produto.Quantidade);
        Console.WriteLine("Preço unitário: " + produto.PrecoUnitario);
    }
}
