using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEstacionamento.Entities.Enum;

namespace AppEstacionamento.Entities
{
    internal class Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public Setor setor { get; set; }
        private static int _avaliação = 0;
        public static List<Funcionario> ListaFuncionario { get; set; } = new List<Funcionario>();

        public Funcionario(int id, string nome, string cPF,Setor setor)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            this.setor = setor;
        }
        public void CadastrarFuncionario(Funcionario fuc)
        {
            _avaliação++;
            ListaFuncionario.Add(fuc);
        }
        public void ListarFuncionarios()
        {
            foreach(Funcionario funci in ListaFuncionario)
            {
                Console.WriteLine(funci.ToString());
            }
        }

        public override string ToString()
        {
            return $"[Nome: {Nome}] [CPF: {CPF}] [Setor: {setor}] [Avaliação: {_avaliação}]";
        }

    }
}
