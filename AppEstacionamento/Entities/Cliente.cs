using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace AppEstacionamento.Entities
{
    internal class Cliente 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        
        public Veiculo veiculo { get; set; }
              
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; } = null;
        public static List<Cliente> ListaCliente { get; set; } = new List<Cliente> ();

        public Cliente(int id, string nome, string cPF, Veiculo veiculo)        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            this.veiculo = veiculo;
            
        }


        public Cliente(string nome, string cPF,DateTime entrada, Veiculo c)
        {
            Nome = nome;
            CPF = cPF;
            veiculo = c;
            Entrada = entrada;
        }
        public void CadastrarCliente(Cliente c)
        {
            ListaCliente.Add(c);
        }
        public void MarcarEntrada(Cliente c)
        {
            ListaCliente.Add(c);
            Vagas.OcuparVaga(c);
            Id++;
        }
        public void MarcarSaida(int id) 
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            foreach (Cliente c in ListaCliente)
            {
                if (c.Id == id)
                {
                    c.Saida = d;
                 
                }
            }         
        }
        public void Listar()
        {
            Console.WriteLine();
            Console.WriteLine("                         LISTA DE CLIENTES                             ");
            foreach(Cliente c in ListaCliente)
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
                cli= $"CLINTE: [ID: {Id}] [Nome: {Nome}] [CPF: {CPF}] [Entrada: {Entrada}] [Saida: Saida não marcada] | CARRO: [Modelo: {veiculo.Modelo}] [Marca: {veiculo.Marca}] [Placa: {veiculo.Placa}] [{veiculo.tipoveiculo}] [Valor: {veiculo.ValorPorHora.ToString("F2")}]";
            }
            else
            {
                cli= $"CLINTE: [ID: {Id}] [Nome: {Nome}] [CPF: {CPF}] [Entrada: {Entrada}] [Saida: {Saida}] | CARRO: [Modelo: {veiculo.Modelo}] [Marca: {veiculo.Marca}] [Placa: {veiculo.Placa}]";

            }
            return cli;
            
        }
    }
}
