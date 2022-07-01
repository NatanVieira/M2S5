namespace M2S5.Entidades {
    public class Empregado {
        public int id { get; set; }
        public string nome { get; set; }

        public Empregado() { }

        public Empregado(int id, string nome) {
            this.id = id;
            this.nome = nome;
        }

        public void Trabalhar() {
            Console.WriteLine("Método Trabalhar Empregado");
        }

        public void IrEmbora() {
            Console.WriteLine("Método IrEmbora Empregado");
        }

        public void TirarFolga() {
            Console.WriteLine("Método TirarFolga Empregado");
        }
    }
}
