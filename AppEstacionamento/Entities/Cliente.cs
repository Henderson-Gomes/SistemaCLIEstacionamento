using System;
using System.Collections.Generic;
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
        public static List<Cliente> ListaCarros { get; set; } = new List<Cliente> ();
        public Cliente(string nome, string cPF,DateTime entrada, Veiculo c)
        {
            Nome = nome;
            CPF = cPF;
            veiculo = c;
            Entrada = entrada;
        }
        public void Cadastrar(Cliente c)
        {
            using (var Workbook = new XLWorkbook())
            {
                var Worksheet = Workbook.Worksheets.Add("Clientes");
                Worksheet.Cell("A2").Value = c.Id;
                Worksheet.Cell("B2").Value = c.Nome;
                Worksheet.Cell("C2").Value = c.CPF;

                Workbook.SaveAs(@"C:\Users\hende\OneDrive\Documentos\Sistema de Gerenciamento PETSHOP\AppEstacionamento\AppEstacionamento\Dados\Dados.xlsx");

            }
        }
        public void MarcarEntrada(Cliente c)
        {
            ListaCarros.Add(c);
            Vagas.OcuparVaga(c);
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
