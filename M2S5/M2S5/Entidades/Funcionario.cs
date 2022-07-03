namespace M2S5.Entidades {
    public class Funcionario {

        public string nome { get; set; } 
        public string id { get; set; }

        public Funcionario() { }

        public Funcionario(string nome,string id) {
            this.nome = nome;
            this.id = id;   
        }
    }
}
