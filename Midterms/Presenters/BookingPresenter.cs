using Midterms.Models;
using Midterms.Services;
using Midterms.Views;

namespace Midterms.Presenters;

public class BookingPresenter
{
    private readonly IBookingView _view;
    private readonly IWonderRepository _repo;

    public BookingPresenter(IBookingView view, IWonderRepository repo)
    {
        _view = view;
        _repo = repo;
    }

    public void Load() => _view.ShowWonders(_repo.GetAll());

    public void RecalculateTotal(BookingRequest request)
    {
        var wonder = _repo.GetById(request.WonderId);
        _view.ShowTotal(wonder is null ? 0 : wonder.PricePerPerson * request.Travelers);
    }

    public void Submit(BookingRequest request)
    {
        var wonder = _repo.GetById(request.WonderId);
        if (wonder is null) return;

        var reference = $"WND-{Random.Shared.Next(100000, 999999)}";
        _view.ShowConfirmation(reference,
            $"Thanks {request.FullName}! Your {wonder.Name} tour for {request.Travelers} on " +
            $"{request.TravelDate:MMM d, yyyy} is reserved. A confirmation was sent to {request.Email}.");
    }
}
