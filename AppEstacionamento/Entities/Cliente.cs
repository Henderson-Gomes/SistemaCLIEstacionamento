using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppEstacionamento.Entities
{
    internal class Cliente 
    {
        public  int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        
        
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public static List<Cliente> ListaCarros { get; set; } = new List<Cliente> ();
    

        

        public Cliente(string nome, string cPF, string modelo, string marca, string placa, DateTime entrada,int id)
        {
            Nome = nome;
            CPF = cPF;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
            Entrada = entrada;
            Id = id;

            
        }

        public void MarcarEntrada(Cliente c)
        {
            ListaCarros.Add(c);
        }
        public void MarcarSaida(int id) 
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            foreach (Cliente c in ListaCarros)
            {
                if (c.Id == id)
                {
                    c.Saida = d;
                 
                }
            }
            {

            }
        }
        public void Listar()
        {
            Console.WriteLine();
            Console.WriteLine("                         LISTA DE CLIENTES                             ");
            foreach(Cliente c in ListaCarros)
            {
                Console.WriteLine(c);
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }
        
        public override string ToString()
        {
            return $"[Nome: {Nome}] [CPF: {CPF}] [Modelo: {Modelo}] [Marca: {Marca}] [Placa: {Placa}] [Entrada: {Entrada}] [Saida: {Saida}]";
        }
    }
}
