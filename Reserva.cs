using System;
using System.Collections.Generic;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
    public Suite? Suite { get; set; }

    public int DiasReservados { get; set; }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Capacidade da suíte excedida");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados > 10)
        {
            valor *= 0.9m; // 10% de desconto
        }

        return valor;
    }
}