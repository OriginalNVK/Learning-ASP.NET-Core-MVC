using MyFirstWebApp.Models;

namespace MyFirstWebApp.Services
{
    public interface IHangHoaRepository
    {
        List<HangHoaModel> GetAll(string search);
    }
}
