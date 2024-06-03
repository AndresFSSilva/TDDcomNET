using Calculadora.Entities;

namespace CalculadoraTest;

public class CalculadoraTeste
{
    private CalculadoraNew _calc;

    public CalculadoraTeste()
    {
        _calc = new CalculadoraNew();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        //Act
        int resultadoCalculadora = _calc.Somar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 12)]
    [InlineData(5, 5, 25)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        //Act
        int resultadoCalculadora = _calc.Multiplicar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        //Act
        int resultadoCalculadora = _calc.Subtrair(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        //Act
        int resultadoCalculadora = _calc.Dividir(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        //Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        //Arrange
        _calc.Somar(1, 2);
        _calc.Somar(2, 8);
        _calc.Somar(3, 7);
        _calc.Somar(4, 1);

        //Act
        var lista = _calc.Historico();

        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}