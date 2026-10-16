using Midterms.Models;

namespace Midterms.Services;

public interface IWonderRepository
{
    IReadOnlyList<Wonder> GetAll();
    Wonder? GetById(int id);
}
