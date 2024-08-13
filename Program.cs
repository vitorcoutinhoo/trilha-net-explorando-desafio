using trilha_net_explorando_desafio.Models;

Reserva reserva1 = new Reserva();
Reserva reserva2 = new Reserva();

Suite suite1 = new Suite(1, "Standard");
Suite suite2 = new Suite(2, "Premium");

Pessoa pessoa1 = new Pessoa("João", "Silva", "11999999999");
Pessoa pessoa2 = new Pessoa("Maria", "Santos", "11999999999");

Pessoa pessoa3 = new Pessoa("José", "Silva", "11999999999");
Pessoa pessoa4 = new Pessoa("Ana", "Santos", "11999999999");

reserva1.AdicionarSuite(suite1);
reserva1.DefinirDias(5);
reserva1.ReservarSuite([pessoa1, pessoa2]);

reserva2.AdicionarSuite(suite2);
reserva2.DefinirDias(10);
reserva2.ReservarSuite([pessoa3, pessoa4]);

System.Console.WriteLine(reserva1);
System.Console.WriteLine("--------------------");
System.Console.WriteLine(reserva2);

reserva1.CancelarReserva();
System.Console.WriteLine("--------------------");
System.Console.WriteLine(reserva1);








