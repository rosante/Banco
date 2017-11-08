namespace Dados
{
    public class ContaPJ:Conta
    {
        public Empresa empresa { get; set; }

        public override void Sacar(double Valor){
            base.Saldo -= (Valor + 0.50);
        } 
        public override void Depositar(double Valor){
            base.Saldo += (Valor - 0.05);
            
        } 
    }
}