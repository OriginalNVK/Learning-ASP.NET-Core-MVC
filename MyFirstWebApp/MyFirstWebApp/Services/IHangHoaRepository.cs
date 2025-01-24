using MyFirstWebApp.Models;

namespace MyFirstWebApp.Services
{
    public interface IHangHoaRepository
    {
        List<HangHoaModel> GetAll(string? search, double? from, double? to, int pageNumber, int pageSize);
    }
}
