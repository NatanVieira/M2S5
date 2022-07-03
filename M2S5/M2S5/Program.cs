using M2S5.Entidades;

namespace M2S5;

public class Program {

    static void Main(string[] args) {

        #region Exercicio 1
        //Empregado empregado = new Empregado();
        //empregado.id = 1;
        //empregado.nome = "Natanael";

        //SalarioEmpregado salarioEmpregado = new SalarioEmpregado(2,"Susane",22,1500);

        //FuncionarioHorista horista = new FuncionarioHorista(3,"Izabel","123456",0.5);

        //Secretaria secretaria = new Secretaria(4,"Paulo",123544,1500,3);

        //Console.WriteLine("Métodos Empregado");
        //empregado.Trabalhar();
        //empregado.IrEmbora();
        //empregado.TirarFolga();

        //Console.WriteLine("Métodos SalarioEmpregado");
        //salarioEmpregado.Trabalhar();
        //salarioEmpregado.IrEmbora();
        //salarioEmpregado.TirarFolga();
        //salarioEmpregado.CalcularFolhaPagamento();

        //Console.WriteLine("Métodos Horista");
        //horista.TirarFolga();
        //horista.Trabalhar();
        //horista.IrEmbora();
        //horista.CalcularTaxas();
        //horista.EmitirNota();

        //Console.WriteLine("Métodos Secretaria");
        //secretaria.Trabalhar();
        //secretaria.TirarFolga();
        //secretaria.IrEmbora();
        //secretaria.AtenderCliente();
        //secretaria.RealizarLigacoes();
        #endregion

        #region Exercicio 2
        Cartao cartao = new Cartao();
        cartao.valorTaxa = 2;
        cartao.saldo = 100;
        cartao.bandeira = "visa";

        CartaoVA cartaoVA = new CartaoVA();
        cartaoVA.bandeira = "mastercard";
        cartaoVA.saldo = 200;
        cartaoVA.valorTaxa = 3;

        CartaoVR cartaoVR = new CartaoVR();
        cartaoVR.valorTaxa = 4;
        cartaoVR.bandeira = "visa";
        cartaoVR.saldo = 300;

        CartaoVT cartaoVT = new CartaoVT();
        cartaoVT.bandeira = "mastercard";
        cartaoVT.valorTaxa = 5;
        cartaoVT.saldo = 400;

        Console.WriteLine($"Taxa Cartao: {cartao.VerificarValorTaxa(cartao.saldo,cartao.valorTaxa)}");
        Console.WriteLine($"Taxa CartaoVA: {cartaoVA.VerificarValorTaxa(cartaoVA.saldo,cartaoVA.valorTaxa)}");
        Console.WriteLine($"Taxa CartaoVR: {cartaoVR.VerificarValorTaxa(cartaoVR.saldo,cartaoVR.valorTaxa)}");
        Console.WriteLine($"Taxa CartaoVT: {cartaoVT.VerificarValorTaxa(cartaoVT.saldo,cartaoVT.valorTaxa)}");


        #endregion

        #region Exercicio 3

        Cartao cartaoEx3 = new CartaoVA();
        CartaoVA cartao2Ex3 = new Cartao();

        #endregion

    }
}