using Absoluta.Pagamentos.Domain;
using Absoluta.Pagamentos.Domain.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Absoluta.Pagamentos.DataAccess.Repositorios;

public class Repository<T> : IRepository<T> where T : class, IEntidade
{
    private readonly AbsolutaContext _ctx;
    private readonly DbSet<T> _dbSet;

    protected Repository(AbsolutaContext ctx)
    {
        _ctx = ctx;
        _dbSet = _ctx.Set<T>();
    }

    public virtual async Task<T?> ObterAsync(int id) => await _dbSet.FindAsync(id);

    public virtual async Task<bool> AdicionarAsync(T entidade)
    {
        await _dbSet.AddAsync(entidade);
        return await _ctx.SaveChangesAsync();
    }

    public virtual async Task<bool> AtualizarAsync(T entidade)
    {
        _dbSet.Update(entidade);
        return await _ctx.SaveChangesAsync();
    }

    public virtual async Task<bool> DeletarAsync(int id)
    {
        var ent = await ObterAsync(id);
        if (ent != null)
            _dbSet.Remove(ent);

        return await _ctx.SaveChangesAsync();
    }
}
