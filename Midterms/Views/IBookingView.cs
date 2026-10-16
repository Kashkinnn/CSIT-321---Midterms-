using Midterms.Models;

namespace Midterms.Views;

public interface IBookingView
{
    void ShowWonders(IReadOnlyList<Wonder> wonders);
    void ShowTotal(decimal total);
    void ShowConfirmation(string reference, string message);
}
