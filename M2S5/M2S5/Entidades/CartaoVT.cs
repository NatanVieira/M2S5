namespace M2S5.Entidades {
    public class CartaoVT : Cartao{

        public CartaoVT() { }

        public override double VerificarValorTaxa(double saldo,double valorTaxa) {
            return saldo * 0.05;
        }
    }
}
