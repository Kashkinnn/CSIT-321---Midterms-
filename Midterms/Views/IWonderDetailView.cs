using Midterms.Models;

namespace Midterms.Views;

public interface IWonderDetailView
{
    void ShowWonder(Wonder wonder);
    void ShowRelated(IReadOnlyList<Wonder> related);
    void ShowNotFound();
}
