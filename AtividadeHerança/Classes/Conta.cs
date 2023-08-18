public class Conta
{
    public int NumeroConta { get; set; }
    public string Agencia { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public double Valor { get; set; }

    public virtual bool Sacar()
    {



    }

    public double Depositar()
    {



    }


}