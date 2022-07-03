namespace M2S5.Entidades {
    public class Cartao {
        public string bandeira { get; set; }
        public double saldo { get; set; }
        public double valorTaxa { get; set; }

        public Cartao() { }

        public virtual double VerificarValorTaxa(double saldo, double valorTaxa) {
            return saldo * (valorTaxa / 100);
        }
    }
}
