
public class Cliente : Pessoa
{

    public int Conta;

    //================================================================================
    public Cliente()
    {

    }

    //================================================================================

    public void definirConta(int conta)
    {
        this.Conta = conta;
    }

    public void imprimirCliente()
    {
        Console.WriteLine("\n---- CLIENTE ----\n");
        imprimirPessoa();
        Console.WriteLine("Conta: " + this.Conta);
    }

    //================================================================================


} // Fim da classe

