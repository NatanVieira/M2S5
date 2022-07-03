namespace M2S5.Entidades {
    public class CartaoVR: Cartao {

        public CartaoVR() { }

        public override double VerificarValorTaxa(double saldo,double valorTaxa) {
            return saldo * 0.01;
        }
    }
}
