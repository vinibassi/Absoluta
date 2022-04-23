using Absoluta.Pagamentos.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absoluta.Pagamentos.DataAccess;

public class Repository<T> where T : class :IEntidade
{
    private readonly AbsolutaContext _ctx;
    protected Repository(AbsolutaContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<T?> ObterAsync(int clienteId) => await _db.Clientes.FindAsync(clienteId);

    public async Task<bool> AdicionarAsync(Cliente cliente)
    {
        await _db.Clientes.AddAsync(cliente);
        return await _db.SaveChangesAsync();
    }

    public async Task<bool> AtualizarAsync(Cliente cliente)
    {
        _db.Clientes.Update(cliente);
        return await _db.SaveChangesAsync();
    }

    public Task<bool> DeletarAsync(int clienteId)
    {
        _db.Clientes.(c => c.Id == clienteId);
        throw new NotImplementedException();
    }

    private DbSet<T> SetDb() => _ctx.Set<T>();
}
