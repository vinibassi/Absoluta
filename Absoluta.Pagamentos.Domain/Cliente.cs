namespace Absoluta.Pagamentos.Domain;

public class Cliente
{
    public Cliente(string nome, Periodo periodo, Destino destino, bool ehMenor, string? nomeDosPais = null)
    {
        Nome = nome;
        Periodo = periodo;
        Destino = destino;
        EhMenor = ehMenor;
        NomeDosPais = nomeDosPais;

        Mensalidades = new List<Mensalidade>();
    }

    public Periodo Periodo { get; private set; }
    public Destino Destino { get; private set; }
    public IList<Mensalidade> Mensalidades { get; set; }

    public string Nome { get; set; }
    public bool EhMenor { get; set; }
    public bool EhPgtoEspecial { get; set; }
    public string? NomeDosPais { get; set; }
    public string? Observação { get; set; }

    public void AlterarPeriodo(Periodo novoPeriodo) => Periodo = novoPeriodo;
    public void AlterarDestino(Destino novoDestino) => Destino = novoDestino;
    public void TornarMaiorDeIdade() => EhMenor = false;
    public void TornarPagamentoEspecial() => EhPgtoEspecial = true;
    public void AdicionarMensalidade(Mensalidade mensalidade) => Mensalidades.Add(mensalidade);
}
