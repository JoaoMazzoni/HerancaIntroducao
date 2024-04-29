public class Funcionario : Pessoa
{
    public string Cargo; //Atributos
    public int Codigo;

    //===========================================================================================

    public Funcionario() //Construtor
    {

    }

    //===========================================================================================

    public void definirCargo(string cargo) //Métodos
    {
        this.Cargo = cargo;
    }

    public void definirCodigo(int codigo)
    {
        this.Codigo = codigo;
    }

    public void imprimirFuncionario()
    {
        Console.WriteLine("\n---- FUNCIONÁRIO ----\n");
        imprimirPessoa(); //Função da classe Pessoa reaproveitada pela herança entre elas.
        Console.WriteLine("Cargo: " + this.Cargo);
        Console.WriteLine("Código: " + this.Codigo);
    }

    //===========================================================================================

}//Fim da classe

