namespace M2S5.Entidades {
    public class SalarioEmpregado : Empregado {

        public int codigoFuncionario { get; set; }
        public double valorSalario { get; set; }

        public SalarioEmpregado() { }

        public SalarioEmpregado(int id, string nome, int codigoFuncionario, double valorSalario)
            :base(id,nome) {
            this.codigoFuncionario = codigoFuncionario;
            this.valorSalario = valorSalario;
        }

        public void CalcularFolhaPagamento() {
            Console.WriteLine("Método CalcularFolhaPagamento SalarioEmpregado");
        }
    }
}
