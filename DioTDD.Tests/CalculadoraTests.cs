using DioTDD.Console;

namespace DioTDD.Tests;

public class CalculadoraTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(10, 20, 30)]
    [InlineData(1000, 2000, 3000)]
    public void CalcularSoma_ComDiversosValores_DeveRetornarValorCorreto(int val1, int val2, int resultado)
    {
        var calc = new Calculadora();
        var resultadoCalculadora = calc.Somar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 5, 2)]
    [InlineData(10, 10, 1)]
    [InlineData(1000, 10, 100)]
    public void CalcularDivisao_ComDiversosValores_DeveRetornarValorCorreto(int val1, int val2, int resultado)
    {
        var calc = new Calculadora();
        var resultadoCalculadora = calc.Dividir(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void CalcularDivisao_DividindoPorZero_DeveRetornarUmaException()
    {
        var calc = new Calculadora();
        int val1 = 10;
        int val2 = 0;
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(val1, val2));
    }

    [Theory]
    [InlineData(10, 2, 20)]
    [InlineData(10, 10, 100)]
    [InlineData(1000, 10, 10000)]
    public void CalcularMultiplicacao_ComDiversosValores_DeveRetornarValorCorreto(int val1, int val2, int resultado)
    {
        var calc = new Calculadora();
        var resultadoCalculadora = calc.Multiplicar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(10, 10, 0)]
    [InlineData(1000, 10, 990)]
    public void CalcularSubtracao_ComDiversosValores_DeveRetornarValorCorreto(int val1, int val2, int resultado)
    {
        var calc = new Calculadora();
        var resultadoCalculadora = calc.Subtrair(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void FazerCalculos_ComDiversosValores_DeveRetornarHistoricoCorreto()
    {
        var calc = new Calculadora();
        calc.Somar(10, 10);
        calc.Multiplicar(10, 10);
        calc.Subtrair(10, 10);

        var historico = calc.ObterHistorico();

        Assert.Equal(3, historico.Count);
        Assert.Equal($"10 + 10", historico[0]);
        Assert.Equal($"10 x 10", historico[1]);
        Assert.Equal($"10 - 10", historico[2]);
    }

}
