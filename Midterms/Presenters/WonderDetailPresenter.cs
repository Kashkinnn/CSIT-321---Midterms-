using Midterms.Services;
using Midterms.Views;

namespace Midterms.Presenters;

public class WonderDetailPresenter
{
    private readonly IWonderDetailView _view;
    private readonly IWonderRepository _repo;

    public WonderDetailPresenter(IWonderDetailView view, IWonderRepository repo)
    {
        _view = view;
        _repo = repo;
    }

    public void Load(int id)
    {
        var wonder = _repo.GetById(id);
        if (wonder is null)
        {
            _view.ShowNotFound();
            return;
        }

        _view.ShowWonder(wonder);
        _view.ShowRelated(_repo.GetAll().Where(w => w.Id != id).Take(3).ToList());
    }
}
