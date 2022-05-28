using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Diagnostics;
namespace AppEstacionamento.Entities
{
    public class Planilha
    {

        public void ExcutarPlanilha()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Clientes");
                workSheet.Cell("A2").Value = "henderson";
                
               // workbook.SaveAs(@"C:\Users\hende\OneDrive\Documentos\Sistema de Gerenciamento PETSHOP\AppEstacionamento\AppEstacionamento\Dados\Dados.xlsx");

                workbook.Save();
            }
            Process.Start(new ProcessStartInfo(@"C:\Program Files\Blender Foundation\Blender 3.0\blender-launcher.exe") { UseShellExecute = true });

        }
    }
}
