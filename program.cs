using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa("João"),
            new Pessoa("Maria")
        };

     
        Suite suite = new Suite("Premium", 2, 150.00m);

        Reserva reserva = new Reserva(12);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: R$ {reserva.CalcularValorDiaria()}");
    }
}