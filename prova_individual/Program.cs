using System;

public class Pessoa
{
    private string cpf;

    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    public string CPF
    {
        get { return cpf; }
        set
        {
            if (value.Length != 11)
            {
                throw new ArgumentException("O CPF deve ter exatamente 11 dígitos.");
            }
            cpf = value;
        }
    }

    public Pessoa(string nome, DateTime dataNascimento, string cpf)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
    }
}

public class AlturaNegativaException : Exception
{
    public AlturaNegativaException(string message) : base(message) { }
}

public class PesoNegativoException : Exception
{
    public PesoNegativoException(string message) : base(message) { }
}

public class Treinador : Pessoa
{
    public string CREF { get; set; }

    public Treinador(string nome, DateTime dataNascimento, string cpf, string cref)
        : base(nome, dataNascimento, cpf)
    {
        CREF = cref;
    }
}
public class Cliente : Pessoa
{
    private double altura;
    private double peso;

    public double Altura
    {
        get { return altura; }
        set
        {
            if (value < 0)
            {
                throw new AlturaNegativaException("Altura não pode ser negativa.");
            }
            altura = value;
        }
    }

    public double Peso
    {
        get { return peso; }
        set
        {
            if (value < 0)
            {
                throw new PesoNegativoException("Peso não pode ser negativo.");
            }
            peso = value;
        }
    }

    public Cliente(string nome, DateTime dataNascimento, string cpf, double altura, double peso)
        : base(nome, dataNascimento, cpf)
    {
        Altura = altura;
        Peso = peso;
    }
}