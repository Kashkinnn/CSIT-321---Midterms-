using Midterms.Models;
using Midterms.Views;

namespace Midterms.Presenters;

public class AboutPresenter
{
    private readonly IAboutView _view;

    public AboutPresenter(IAboutView view) => _view = view;

    public void Load() => _view.ShowStats(new List<(string, string)>
    {
        ("Destinations", "5"),
        ("Happy travelers", "12,400+"),
        ("Local guides", "180"),
        ("Years of experience", "15"),
    });

    public void SendMessage(ContactMessage message) =>
        _view.ShowContactResult($"Thank you, {message.Name}. We'll reply to {message.Email} within 24 hours.");
}
