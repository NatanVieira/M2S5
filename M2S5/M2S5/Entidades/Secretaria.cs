namespace M2S5.Entidades {
    public class Secretaria : SalarioEmpregado {
        public int qtdAnosEmpresa { get; set; }

        public Secretaria() { }

        public Secretaria(int id, string nome, int codigoFuncionario, double valorSalario, int qtdAnosEmpresa)
            :base(id, nome,codigoFuncionario,valorSalario) {
            this.qtdAnosEmpresa = qtdAnosEmpresa;
        }

        public void AtenderCliente() {
            Console.WriteLine("Método AtenderCliente Secretaria");
        }

        public void RealizarLigacoes() {
            Console.WriteLine("Método RealizarLigacoes Secretaria");
        }
    }
}
