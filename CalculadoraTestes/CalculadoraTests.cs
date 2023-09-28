using System.Reflection.Metadata;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    
    private CalculadoraImplementacao _calc;
    public CalculadoraTests(){
        _calc = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5Com10eRetornar15()
    {
        
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act Agir
        int resultado = _calc.somar(num1,num2);

        //Assert
        Assert.Equal(15,resultado);

    }

     [Fact]
    public void DeveSomar5Com15eRetornar20()
    {
        
        //Arrange
        int num1 = 5;
        int num2 = 15;

        //Act Agir
        int resultado = _calc.somar(num1,num2);

        //Assert
        Assert.Equal(20,resultado);

    }

     [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        
        //Arrange
        int num1 = 4;
        
        //Act Agir
        bool resultado = _calc.EhPar(num1);

        //Assert
        Assert.True(resultado);

    }

    [Theory]
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6,8,10})]
    /*[InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]*/
    
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros){

        //act 
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));


    }
}