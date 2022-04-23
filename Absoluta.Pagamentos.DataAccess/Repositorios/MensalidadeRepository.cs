using Absoluta.Pagamentos.Domain;
using Absoluta.Pagamentos.Domain.RepoInterfaces;

namespace Absoluta.Pagamentos.DataAccess.Repositorios;

public class MensalidadeRepository : Repository<Mensalidade>, IMensalidadeRepository
{
    private readonly AbsolutaContext _ctx;

    public MensalidadeRepository(AbsolutaContext ctx) : base(ctx)
    {
        _ctx = ctx;
    }
}
