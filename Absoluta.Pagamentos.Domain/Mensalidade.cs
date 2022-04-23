using Absoluta.Pagamentos.Domain.Enums;

namespace Absoluta.Pagamentos.Domain;

public class Mensalidade
{
    public Mensalidade(decimal valor, DateOnly dataDoVencimento)
    {
        Valor = valor;
        DataDoVencimento = dataDoVencimento;
        Status = StatusMensalidade.Pendente;
    }

    public decimal Valor { get; private set; }
    public DateOnly DataDoVencimento { get; private set; }
    public StatusMensalidade Status { get; private set; }
    public DateTime? DataDoPagamento { get; private set; }

    public void AlterarDataDeVencimento(DateOnly novaDataVencimento) => DataDoVencimento = novaDataVencimento;
    public void AlterarStatus(StatusMensalidade novoStatus) => Status = novoStatus;
    public void AlterarValor(decimal novoValor) => Valor = novoValor;
    public void SalvarDataDoPagamento() => DataDoPagamento = DateTime.Now;
    public Mensalidade ClonarMensalidade() => new(Valor, DataDoVencimento.AddMonths(1));
}
