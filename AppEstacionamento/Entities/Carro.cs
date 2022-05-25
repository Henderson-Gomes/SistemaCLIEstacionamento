using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstacionamento.Entities
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        public Carro(string modelo, string marca, string placa)
        {
            Modelo = modelo;
            Marca = marca;
            Placa= placa;
        }
        
    }
}
