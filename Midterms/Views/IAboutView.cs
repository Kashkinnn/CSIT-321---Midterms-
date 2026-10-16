namespace Midterms.Views;

public interface IAboutView
{
    void ShowStats(IReadOnlyList<(string Label, string Value)> stats);
    void ShowContactResult(string message);
}
