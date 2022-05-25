using AppEstacionamento.Entities;


int id = 0;
Cliente cliente = new Cliente("Henderson", "442.063.338-74", "HB20", "Honda", "HEZ76", DateTime.Now,id++);
cliente.MarcarEntrada(cliente);
cliente = new Cliente("Gizelli", "442.872.112-74", "RC22", "GIP", "YUN23", DateTime.Now,id++);
cliente.MarcarEntrada(cliente);

DesingMenu();


 void DesingMenu()
{
    int resp = 0;
    do
    {

        Console.WriteLine("                    MENU                    ");
        Console.WriteLine("+------------------------------------------+");
        Console.WriteLine("[1] Lista dos Carros");
        Console.WriteLine("[2] Marcar Entrada");
        Console.WriteLine("[3] Marcar Saida");
        Console.WriteLine("[4] Sair ");
        Console.WriteLine("+------------------------------------------+");
        resp = Convert.ToInt32(Console.ReadLine()); 

        switch (resp)
        {
            case 1:
                cliente.Listar();
                DesingMenu();

                break;
            case 2:
                cliente = new Cliente("Hathos", "332.322.999-32", "YAMAHA", "YINLDAI", "VS288", DateTime.Now, 3);
                cliente.MarcarEntrada(cliente);

                break;
            case 3:
                Console.WriteLine("ID do cliente: ");
                int id = Convert.ToInt32(Console.Read());
                cliente.MarcarSaida(id);
                DesingMenu(); 
                break;

        }
    } while (resp != 4);
    
    
}