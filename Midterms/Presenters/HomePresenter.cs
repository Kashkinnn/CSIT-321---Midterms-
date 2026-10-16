using Midterms.Services;
using Midterms.Views;

namespace Midterms.Presenters;

public class HomePresenter
{
    private readonly IHomeView _view;
    private readonly IWonderRepository _repo;

    public HomePresenter(IHomeView view, IWonderRepository repo)
    {
        _view = view;
        _repo = repo;
    }

    public void Load()
    {
        _view.ShowWonders(_repo.GetAll());
        _view.ShowActiveWonder(0);
    }

    public void OnScrollIndexChanged(int index)
    {
        var count = _repo.GetAll().Count;
        _view.ShowActiveWonder(Math.Clamp(index, 0, count - 1));
    }
}
