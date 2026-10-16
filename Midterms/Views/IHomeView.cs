using Midterms.Models;

namespace Midterms.Views;

public interface IHomeView
{
    void ShowWonders(IReadOnlyList<Wonder> wonders);
    void ShowActiveWonder(int index);
}
