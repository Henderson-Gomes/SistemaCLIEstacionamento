using AppEstacionamento.Entities;
using AppEstacionamento.Entities.Enum;

int id = 0;


Veiculo carro = new Veiculo("HB20", "Honda", "HEZ76", TipoVeiculo.Carro);
Cliente cliente = new Cliente("Henderson", "442.063.338-74", DateTime.Now,carro);

cliente.MarcarEntrada(cliente);
carro = new Veiculo("RC22", "GIP", "YUN23", TipoVeiculo.Carro);
cliente = new Cliente("Gizelli", "442.872.112-74", DateTime.Now,carro);

cliente.MarcarEntrada(cliente);

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
        Console.WriteLine("[4] Sair ");
        Console.WriteLine("+------------------------------------------+");
        resp = int.Parse(Console.ReadLine()); 

        switch (resp)
        {
            case 1:
                cliente.Listar();
                DesingMenu();

                break;
            case 2:
                carro = new Veiculo("YAMAHA", "YINLDAI", "VS288",TipoVeiculo.Moto);
                cliente = new Cliente("Hathos", "332.322.999-32", DateTime.Now,carro);
                cliente.MarcarEntrada(cliente);

                break;
            case 3:
                Console.WriteLine("ID do cliente: ");
                int id = int.Parse(Console.ReadLine());
                cliente.MarcarSaida(id);
                DesingMenu(); 
                break;

        }
    } while (resp != 4);
    
    
}