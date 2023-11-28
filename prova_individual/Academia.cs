using System;
using System.Collections.Generic;
using System.Linq;
using pessoa;

public class Academia
{
    public List<Cliente> Clientes { get; private set; }
    public List<Treinador> Treinadores { get; private set; }

    public Academia()
    {
        Clientes = new List<Cliente>();
        Treinadores = new List<Treinador>();
    }

    public void AdicionarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void AdicionarTreinador(Treinador treinador)
    {
        Treinadores.Add(treinador);
    }

    public List<Treinador> RelatorioTreinadoresPorIdade(int idadeMinima, int idadeMaxima)
    {
        DateTime dataAtual = DateTime.Now;
        return Treinadores.Where(treinador =>
            (dataAtual.Year - treinador.DataNascimento.Year) >= idadeMinima &&
            (dataAtual.Year - treinador.DataNascimento.Year) <= idadeMaxima
        ).ToList();
    }

    public List<Cliente> RelatorioClientesPorIdade(int idadeMinima, int idadeMaxima)
    {
        DateTime dataAtual = DateTime.Now;
        return Clientes.Where(cliente =>
            (dataAtual.Year - cliente.DataNascimento.Year) >= idadeMinima &&
            (dataAtual.Year - cliente.DataNascimento.Year) <= idadeMaxima
        ).ToList();
    }
}     
