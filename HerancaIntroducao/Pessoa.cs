public class Pessoa
{
    public string Nome; //Definição dos atributos
    public string Endereco;
    public string Sexo;
    public string Telefone;
    public float Salario;
    public DateOnly Nascimento;

    //==================================================================================================
    public Pessoa() //Construtor
    {

    }

    //==================================================================================================

    public void definirNome(string nome) //Criação dos métodos
    {
        this.Nome = nome;

    }

    public void definirEndereco(string endereco)
    {
        this.Endereco = endereco;
    }

    public void definirSexo(string sexo)
    {
        this.Sexo = sexo;
    }

    public void definirTelefone(string telefone)
    {
        this.Telefone = telefone;
    }

    public void definirSalario(float salario)
    {
        this.Salario = salario;
    }

    public void definirNascimento(DateOnly nascimento)
    {
        this.Nascimento = nascimento;
    }

    public void imprimirPessoa()
    {

        Console.WriteLine("\nNome: " + this.Nome);
        Console.WriteLine("Endereço: " + this.Endereco);
        Console.WriteLine("Sexo: " + this.Sexo);
        Console.WriteLine("Telefone: " + this.Telefone);
        Console.WriteLine("Salário: " + this.Salario);
        Console.WriteLine("Data de Nascimento: " + this.Nascimento);

    }

    //===========================================================================================

} //Fim da CLasse