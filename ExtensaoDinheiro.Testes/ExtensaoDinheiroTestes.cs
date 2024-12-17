namespace DinheiroExtensao.Testes;

[TestClass]
public class ExtensaoDinheiroTestes
{
    [TestMethod]
    public void DeveConverterDecimalParaInteiro()
    {
        decimal valor = 279.98M;
        var centavos = valor.ParaCentavos();
        
        Assert.AreEqual(27998, centavos);
    }
}