using appContaCorrente.Dominio;

Cliente cliente = new Cliente();
Conta conta = new Conta();
Agencia agencia = new Agencia();
Banco banco = new Banco();

Console.WriteLine("Informe o seu nome:");
cliente.nomeCliente = Console.ReadLine();
Console.WriteLine("Informe o numero da sua agencia bancaria: ");
agencia.numeroAgencia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o nome do Banco: ");
banco.nomeBanco = Console.ReadLine();
Console.WriteLine("Informe o numero da sua conta: ");
conta.numeroConta = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Os seus dados informados foram: ");
Console.WriteLine("CLIENTE: {0}", cliente.nomeCliente);
Console.WriteLine("CONTA: {0}", conta.numeroConta);
Console.WriteLine("AGENCIA: {0}", agencia.numeroAgencia);
Console.WriteLine("BANCO: {0}", banco.nomeBanco);
