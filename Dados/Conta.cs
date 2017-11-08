namespace Dados
{
    public class Conta
    {
        public string Numero{get; set;}
        public string Agencia { get; set; }
        public double Saldo { get; protected set; }
        /// <summary>
        /// Retira da conta o valor passado (passe um valor double)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public virtual void Sacar(double valor){
            this.Saldo -= valor;
        }
        /// <summary>
        /// Deposita na conta o valor passado (passe um valor double)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public virtual void Depositar(double valor){
            this.Saldo += valor;
            //return this.Saldo;
        }
       
    }
}