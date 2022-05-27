using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEstacionamento.Entities.Enum;
namespace AppEstacionamento.Entities
{
    internal class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public double ValorPorHora { get; set; }

        public TipoVeiculo tipoveiculo { get; set; }

        public Veiculo(string modelo, string marca, string placa, TipoVeiculo tipo)
        {
            Modelo = modelo;
            Marca = marca;
            Placa= placa;
            tipoveiculo = tipo;
            if (tipoveiculo == TipoVeiculo.Carro)
            {
                ValorPorHora = 15.00;
            }
            else 
            {
                ValorPorHora = 10.00;
            }
        }
        
    }
}
