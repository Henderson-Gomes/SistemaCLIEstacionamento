using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppEstacionamento.Entities;

internal abstract class Vagas
{
    public static Cliente[] VagaCarro = new Cliente[20];
    public static Cliente[] VagaMoto = new Cliente[10];

    public static void OcuparVaga(Cliente c)
    {
        if(c.carro.tipoveiculo == Enum.TipoVeiculo.Carro)
        {
            for (int i=0; i < VagaCarro.Length; i++)
            {
                if(VagaCarro[i] != null)
                {
                    VagaCarro[i] = c;
                }
               
            }
        }
        else
        {
            for (int i = 0; i < VagaMoto.Length; i++)
            {
                if (VagaMoto[i] != null)
                {
                    VagaCarro[i] = c;
                }
            }
        }
    }
    public static void ListarVaga()
    {
        foreach(Cliente CliCarro in VagaCarro)
        {
            Console.WriteLine("Vaga Carros");
            Console.WriteLine(CliCarro);
        }
    }

}
