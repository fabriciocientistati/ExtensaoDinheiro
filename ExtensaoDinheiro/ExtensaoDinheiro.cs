namespace DinheiroExtensao;

public static class Dinheiro
{
    public static int ParaCentavos(this decimal quantidade)
    {
        if (quantidade <= 0)
            return 0;

        var texto = quantidade
            .ToString("N2")
            .Replace(",", "")
            .Replace(".", "");

        if (string.IsNullOrEmpty(texto))
            return 0;

        int.TryParse(texto, out var resultado);

        return resultado;
    }
}
