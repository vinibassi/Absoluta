using Absoluta.Pagamentos.Domain;
using Microsoft.EntityFrameworkCore;

namespace Absoluta.Pagamentos.DataAccess
{
    public class AbsolutaContext : DbContext
    {
        public AbsolutaContext()
        {

        }
        public DbSet<Cliente> Clientes;
        public new async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(true, cancellationToken) > 0;
        }
    }
}
