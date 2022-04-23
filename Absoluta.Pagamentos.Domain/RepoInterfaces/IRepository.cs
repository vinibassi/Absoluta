namespace Absoluta.Pagamentos.Domain.RepoInterfaces;

public interface IRepository<T>
{
    Task<T?> ObterAsync(int id);
    Task<bool> AdicionarAsync(T entidade);
    Task<bool> AtualizarAsync(T entidade);
    Task<bool> DeletarAsync(int id);
}