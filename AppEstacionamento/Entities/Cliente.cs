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
        
        public Carro carro { get; set; }
              
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; } = null;
        public static List<Cliente> ListaCarros { get; set; } = new List<Cliente> ();
    

        

        public Cliente(string nome, string cPF,DateTime entrada,int id, Carro c)
        {
            Nome = nome;
            CPF = cPF;
            carro = c;
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
            string cli;
            if (Saida == null)
            {
                cli= $"CLINTE: [Nome: {Nome}] [CPF: {CPF}] [Entrada: {Entrada}] [Saida: Saida não marcada] | CARRO: [Modelo: {carro.Modelo}] [Marca: {carro.Marca}] [Placa: {carro.Placa}]";
            }
            else
            {
                cli= $"CLINTE: [Nome: {Nome}] [CPF: {CPF}] [Entrada: {Entrada}] [Saida: {Saida}] | CARRO: [Modelo: {carro.Modelo}] [Marca: {carro.Marca}] [Placa: {carro.Placa}]";

            }
            return cli;
            
        }
    }
}
