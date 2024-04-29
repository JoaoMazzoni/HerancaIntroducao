#region cliente1
Cliente cliente1 = new Cliente();

Console.WriteLine("\n|Informe o nome do cliente: ");
cliente1.definirNome(Console.ReadLine());

Console.WriteLine("|Informe o endereço do cliente: ");
cliente1.definirEndereco(Console.ReadLine());

Console.WriteLine("|Informe o sexo do cliente: ");
cliente1.definirSexo(Console.ReadLine()); //Console.ReadLine() lê apenas strings.

Console.WriteLine("|Informe o telefone do cliente: ");
cliente1.definirTelefone(Console.ReadLine());

Console.WriteLine("|Informe o salário do cliente: ");
cliente1.definirSalario(float.Parse(Console.ReadLine()));

Console.WriteLine("|Informe a data de nascimento do cliente: ");
cliente1.definirNascimento(DateOnly.Parse(Console.ReadLine()));

Console.WriteLine("|Informe o número da conta: ");
cliente1.definirConta(int.Parse(Console.ReadLine()));

#endregion
// ============================================================================

#region Funcionario1
Funcionario funcionario1 = new Funcionario();

Console.WriteLine("\n|Informe o nome do funcionário: ");
funcionario1.definirNome(Console.ReadLine());

Console.WriteLine("|Informe o endereço do funcionário: ");
funcionario1.definirEndereco(Console.ReadLine());

Console.WriteLine("|Informe o sexo do funcionário: ");
funcionario1.definirSexo(Console.ReadLine()); //Console.ReadLine() lê apenas strings.

Console.WriteLine("|Informe o telefone do funcionário: ");
funcionario1.definirTelefone(Console.ReadLine());

Console.WriteLine("|Informe o salário do funcionário: ");
funcionario1.definirSalario(float.Parse(Console.ReadLine()));

Console.WriteLine("|Informe a data de nascimento do funcionário: ");
funcionario1.definirNascimento(DateOnly.Parse(Console.ReadLine()));

Console.WriteLine("|Informe o cargo do funcionário: ");
funcionario1.definirCargo(Console.ReadLine());

Console.WriteLine("|Informe o código do funcionário: ");
funcionario1.definirCodigo(int.Parse(Console.ReadLine()));
#endregion



cliente1.imprimirCliente();
funcionario1.imprimirFuncionario();