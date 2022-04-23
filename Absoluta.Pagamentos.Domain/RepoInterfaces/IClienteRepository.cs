namespace Absoluta.Pagamentos.Domain.RepoInterfaces;

public interface IClienteRepository
{
    Task<Cliente?> ObterAsync(int clienteId);
    Task<bool> AdicionarAsync(Cliente cliente);
    Task<bool> AtualizarAsync(Cliente cliente);
    Task<bool> DeletarAsync(int clienteId);
}
