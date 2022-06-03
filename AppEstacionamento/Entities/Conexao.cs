using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AppEstacionamento.Entities
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-3RT97IN\Estacionamento;Initial catalog=Teste;Integrated Security=true";
        }
        public void Conectar()
        {

        }
        public void Desconectar()
        {

        }
    }
}
