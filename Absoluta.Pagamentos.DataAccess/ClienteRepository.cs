using Absoluta.Pagamentos.Domain;
using Absoluta.Pagamentos.Domain.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Absoluta.Pagamentos.DataAccess;

public class ClienteRepository : Repository<Cliente>, IClienteRepository 
{
    private readonly AbsolutaContext _db;
    public ClienteRepository(AbsolutaContext db) : base(db)
    {
        _db = db;
    }

    public async Task<Cliente?> ObterAsync(int clienteId) => await _db.Clientes.FindAsync(clienteId);

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
}
