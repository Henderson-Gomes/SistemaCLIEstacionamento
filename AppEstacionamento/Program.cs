using AppEstacionamento.Entities;
using AppEstacionamento.Entities.Enum;

int id = 0;
Funcionario f = new Funcionario(2, "Jorge", "333.333.333-22", Setor.Manobrista);
f.CadastrarFuncionario(f);
f = new Funcionario(1, "Eduardo", "111.111.111-33", Setor.Atendente);
f.CadastrarFuncionario(f);

//f.ListarFuncionarios();

Veiculo carro = new Veiculo("HB20", "Honda", "HEZ76", TipoVeiculo.Carro);
Cliente cliente = new Cliente("Henderson", "442.000.119-74", DateTime.Now,carro);

cliente.MarcarEntrada(cliente);
carro = new Veiculo("RC22", "GIP", "YUN23", TipoVeiculo.Carro);
cliente = new Cliente("Gizelli", "877.872.112-74", DateTime.Now,carro);

cliente.MarcarEntrada(cliente);
Vagas.ListarVaga();



DesingMenu();


 void DesingMenu()
{
    int resp;
    do
    {
        
        Console.WriteLine("                    MENU                    ");
        Console.WriteLine("+------------------------------------------+");
        Console.WriteLine("[1] Lista dos Carros");
        Console.WriteLine("[2] Marcar Entrada");
        Console.WriteLine("[3] Marcar Saida");
        Console.WriteLine("[4] Listar funcionario");
        Console.WriteLine("[5] Listar Vagas");
        Console.WriteLine("[6] Sair ");
        Console.WriteLine("+------------------------------------------+");
        resp = int.Parse(Console.ReadLine()); 

        switch (resp)
        {
            case 1:
                Console.Clear();
                cliente.Listar();
                DesingMenu();

                break;
            case 2:
                Console.Clear();

                Veiculo veiculo = new Veiculo("YAMAHA", "YINLDAI", "VS288",TipoVeiculo.Moto);
                Cliente cliente2 = new Cliente("Hathos", "332.322.999-32", DateTime.Now,veiculo);
                cliente2.MarcarEntrada(cliente2);

                break;
            case 3:
                Console.Clear();

                Console.WriteLine("ID do cliente: ");
                int id = int.Parse(Console.ReadLine());
                cliente.MarcarSaida(id);
                DesingMenu(); 
                break;
            case 4:
                Console.Clear();
                f.ListarFuncionarios();
                DesingMenu();
                break;
            case 5:
                Console.Clear();
                Vagas.ListarVaga();
                DesingMenu();
                break;
                
        }
    } while (resp != 5);
    
    
}