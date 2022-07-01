using M2S5.Entidades;

namespace M2S5;

public class Program {

    static void Main(string[] args) {

        Empregado empregado = new Empregado();
        empregado.id = 1;
        empregado.nome = "Natanael";

        SalarioEmpregado salarioEmpregado = new SalarioEmpregado(2,"Susane",22,1500);

        FuncionarioHorista horista = new FuncionarioHorista(3,"Izabel","123456",0.5);

        Secretaria secretaria = new Secretaria(4,"Paulo",123544,1500,3);

        Console.WriteLine("Métodos Empregado");
        empregado.Trabalhar();
        empregado.IrEmbora();
        empregado.TirarFolga();

        Console.WriteLine("Métodos SalarioEmpregado");
        salarioEmpregado.Trabalhar();
        salarioEmpregado.IrEmbora();
        salarioEmpregado.TirarFolga();
        salarioEmpregado.CalcularFolhaPagamento();

        Console.WriteLine("Métodos Horista");
        horista.TirarFolga();
        horista.Trabalhar();
        horista.IrEmbora();
        horista.CalcularTaxas();
        horista.EmitirNota();

        Console.WriteLine("Métodos Secretaria");
        secretaria.Trabalhar();
        secretaria.TirarFolga();
        secretaria.IrEmbora();
        secretaria.AtenderCliente();
        secretaria.RealizarLigacoes();
    }
}