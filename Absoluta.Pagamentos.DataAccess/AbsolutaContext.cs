using Absoluta.Pagamentos.Domain;
using Microsoft.EntityFrameworkCore;

namespace Absoluta.Pagamentos.DataAccess;

public class AbsolutaContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; } = default!;

    public AbsolutaContext(DbContextOptions<AbsolutaContext> options) : base(options)
    {

    }
    public new async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(true, cancellationToken) > 0;
    }
}
