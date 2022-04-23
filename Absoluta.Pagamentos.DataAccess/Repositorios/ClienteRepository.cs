using Absoluta.Pagamentos.Domain;
using Absoluta.Pagamentos.Domain.RepoInterfaces;

namespace Absoluta.Pagamentos.DataAccess.Repositorios;

public class ClienteRepository : Repository<Cliente>, IClienteRepository 
{
    private readonly AbsolutaContext _ctx;

    public ClienteRepository(AbsolutaContext ctx) : base(ctx)
    {
        _ctx = ctx;
    }
}
