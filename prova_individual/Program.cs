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


