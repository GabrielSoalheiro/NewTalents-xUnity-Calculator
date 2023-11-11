namespace TestNewTalents;

using NewTalents;
using Xunit;

public class CalculadoraTest
{
    public Calculadora ConstruirCalculadora()
    {
        return new Calculadora("11/11/2023");
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSoma(double a, double b, double resultado)
    {
        Calculadora calculadora = ConstruirCalculadora();
        double resultadoCalculadora = calculadora.Soma(a, b);
        Assert.Equal(resultadoCalculadora, resultado);
    }
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(5, 5, 0)]
    public void TestSubtracao(double a, double b, double resultado)
    {
        Calculadora calculadora = ConstruirCalculadora();
        double resultadoCalculadora = calculadora.Subtracao(a, b);
        Assert.Equal(resultadoCalculadora, resultado);
    }
    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicacao(double a, double b, double resultado)
    {
        Calculadora calculadora = ConstruirCalculadora();
        double resultadoCalculadora = calculadora.Multiplicacao(a, b);
        Assert.Equal(resultadoCalculadora, resultado);
    }
    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(30, 3, 10)]
    public void TestDivisao(double a, double b, double resultado)
    {
        Calculadora calculadora = ConstruirCalculadora();
        double resultadoCalculadora = calculadora.Divisao(a, b);
        Assert.Equal(resultadoCalculadora, resultado);
    }
    [Fact]
    public void TestDivisaoPorZero()
    {
        Calculadora calculadora = ConstruirCalculadora();
        Assert.Throws<DivideByZeroException>(() => calculadora.Divisao(5, 0));
    }
    [Fact]
    public void TestHistorico()
    {
        var calculadora = ConstruirCalculadora();
        for (int i = 0; i < 3; i++) calculadora.Soma(1, 1);
        Assert.Equal(3, calculadora.RetornoHistorico().Count);
    }
}