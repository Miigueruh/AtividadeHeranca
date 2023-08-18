
public class ContaEmpresarial:Conta
{
    public double TaxaAnuidade {  get; set; }
    public double LimiteEmprestimo {  get; set; }
    public double TotalEmprestimo {  get; set; }   

    public override bool Sacar()
    {


        //return base.Sacar();
    }

    public void FazerEmprestimo(double Valor)
    {



    }

}