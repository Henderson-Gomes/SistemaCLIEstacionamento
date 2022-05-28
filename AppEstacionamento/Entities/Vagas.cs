using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppEstacionamento.Entities;

internal abstract class Vagas
{
    public string Nome { get; set; }
    public string CPf { get; set; }
    public int NumeroVaga { get; set; }

    public static Vagas[] VagaMotO = new Vagas[10];
    public static Cliente[] VagaCarro = new Cliente[20];
    public static Cliente[] VagaMoto = new Cliente[10];

    public static void OcuparVaga(Cliente c)
    {
       
        if (c.veiculo.tipoveiculo == Enum.TipoVeiculo.Carro)
        {
            for (int i = 0; i <= VagaCarro.Length; i++)
            {
                if (VagaCarro[i] == null)
                {
                    VagaCarro[i] = c;
                    break;
                }

            }
        }
        else if (c.veiculo.tipoveiculo == Enum.TipoVeiculo.Moto)
        {
            for (int i = 0; i <= VagaMoto.Length; i++)
            {
                if (VagaMoto[i] == null)
                {
                    VagaMoto[i] = c;
                    break;
                }
            }
        }
       
    }
    public static void ListarVaga()
    {
         Console.WriteLine("Vagas de Carros");
 
        foreach (Cliente CliCarro in VagaCarro)
        {
            if (CliCarro!= null)
            {
                Console.WriteLine($"[ID: {CliCarro.Id}] [Nome: {CliCarro.Nome}] [Placa: {CliCarro.veiculo.Placa}]");
            }
            else
            {
                Console.WriteLine("Vaga vazia");
            }

            
        }
        
        Console.WriteLine("Vagas de Moto");
        
        foreach (Cliente CliMoto in VagaMoto)
        {
            if (CliMoto != null)
            {
                Console.WriteLine($"[ID: {CliMoto.Id}] [Nome: {CliMoto.Nome}] [Placa: {CliMoto.veiculo.Placa}]");
            }
            else
            {
                Console.WriteLine("Vaga vazia");
            }
            
        }
    }

}
