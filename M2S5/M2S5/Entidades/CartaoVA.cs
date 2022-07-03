namespace M2S5.Entidades {
    public class CartaoVA : Cartao {

        public CartaoVA() { }

        public override double VerificarValorTaxa(double saldo,double valorTaxa) {
            return saldo * 0.03;
        }
    }
}
