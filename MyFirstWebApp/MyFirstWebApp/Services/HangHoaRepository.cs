using Microsoft.IdentityModel.Tokens;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Services
{
    public class HangHoaRepository : IHangHoaRepository
    {
        private readonly WebDbContext _dbContext;

        public HangHoaRepository(WebDbContext context) {
            _dbContext = context;
        }
        public List<HangHoaModel> GetAll(string search)
        {
            var allProducts = _dbContext.HangHoas.AsQueryable();
            if(!search.IsNullOrEmpty())
            {
                allProducts.Where(hh => hh.TenHH.Contains(search));
            }
             
            var HangHoa = allProducts.Select(hh => new HangHoaModel
            {
                MaHh = hh.MaHh,
                TenHH = hh.TenHH,
                GiaHH = hh.GiaHH,
                TenLoai = hh.Loai.TenLoai
            });

            return HangHoa.ToList();
        }
    }
}
