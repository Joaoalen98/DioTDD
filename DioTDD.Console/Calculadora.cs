namespace DioTDD.Console;

public class Calculadora
{
    private List<string> _historicoResultados;

    public Calculadora()
    {
        _historicoResultados = new List<string>();
    }

    private void GravaHistorico(int val1, int val2, char sinal)
    {
        _historicoResultados.Add($"{val1} {sinal} {val2}");
    }

    public int Somar(int val1, int val2)
    {
        GravaHistorico(val1, val2, '+');
        return val1 + val2;
    }

    public int Dividir(int val1, int val2)
    {
        GravaHistorico(val1, val2, '/');
        return val1 / val2;
    }

    public int Multiplicar(int val1, int val2)
    {
        GravaHistorico(val1, val2, 'x');
        return val1 * val2;
    }

    public int Subtrair(int val1, int val2)
    {
        GravaHistorico(val1, val2, '-');
        return val1 - val2;
    }

    public List<string> ObterHistorico()
    {
        return _historicoResultados;
    }
}
