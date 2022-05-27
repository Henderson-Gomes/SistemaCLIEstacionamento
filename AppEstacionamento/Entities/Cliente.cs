using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppEstacionamento.Entities
{
    internal class Cliente 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        
        public Veiculo carro { get; set; }
              
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; } = null;
        public static List<Cliente> ListaCarros { get; set; } = new List<Cliente> ();
    

        

        public Cliente(string nome, string cPF,DateTime entrada, Veiculo c)
        {
            Nome = nome;
            CPF = cPF;
            carro = c;
            Entrada = entrada;
            
        }

        public void MarcarEntrada(Cliente c)
        {
            ListaCarros.Add(c);
            Id++;
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
                cli= $"CLINTE: [ID: {Id}] [Nome: {Nome}] [CPF: {CPF}] [Entrada: {Entrada}] [Saida: Saida não marcada] | CARRO: [Modelo: {carro.Modelo}] [Marca: {carro.Marca}] [Placa: {carro.Placa}] [{carro.tipoveiculo}] [Valor: {carro.ValorPorHora.ToString("F2")}]";
            }
            else
            {
                cli= $"CLINTE: [ID: {Id}] [Nome: {Nome}] [CPF: {CPF}] [Entrada: {Entrada}] [Saida: {Saida}] | CARRO: [Modelo: {carro.Modelo}] [Marca: {carro.Marca}] [Placa: {carro.Placa}]";

            }
            return cli;
            
        }
    }
}
