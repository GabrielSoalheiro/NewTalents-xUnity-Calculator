namespace NewTalents;
public class Calculadora
{
    private List<string> HistoricoOperacoes { get; set; } = new List<string>();
    private string DataOperacao { get; set; }

    public Calculadora(string dataOperacao)
    {
        HistoricoOperacoes = new List<string>();
        DataOperacao = dataOperacao;
    }

    public double Soma(double a, double b)
    {
        double resultado = a + b;
        HistoricoOperacoes.Add($"Soma: {a} + {b} = {resultado}" + " - data: " + DataOperacao);
        return resultado;
    }

    public double Subtracao(double a, double b)
    {
        double resultado = a - b;
        HistoricoOperacoes.Add($"Subtracao: {a} - {b} = {resultado}" + " - data: " + DataOperacao);
        return resultado;
    }

    public double Multiplicacao(double a, double b)
    {
        double resultado = a * b;
        HistoricoOperacoes.Add($"Multiplicacao: {a} * {b} = {resultado}" + " - data: " + DataOperacao);
        return resultado;
    }

    public double Divisao(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero");
        }
        double resultado = a / b;
        HistoricoOperacoes.Add($"Divisao: {a} / {b} = {resultado}" + " - data: " + DataOperacao);
        return resultado;
    }

    public List<string> RetornoHistorico()
    {
        return HistoricoOperacoes;
    }
}