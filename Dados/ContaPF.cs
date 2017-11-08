namespace Dados
{
    public class ContaPF:Conta
    {
        public string NomeCliente { get; set; }
        public string DataNascimento { get; set; }

        public override void Sacar(double Valor){
            base.Saldo -= (Valor + 0.10);
        } 
        public override void Depositar(double Valor){
            base.Saldo += (Valor - 0.01);
            
        } 
    }
}