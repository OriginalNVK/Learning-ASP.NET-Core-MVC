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
        public List<HangHoaModel> GetAll(string? search = null, double? from = null, double? to = null, int pageNumber = 1, int pageSize = 1)
        {
            var allProducts = _dbContext.HangHoas.AsQueryable();
            if(!string. IsNullOrEmpty(search))
            {
                allProducts = allProducts.Where(hh => hh.TenHH.Contains(search));
            }
                
            #region Filtering
            if(from.HasValue)
                allProducts = allProducts.Where(hh => hh.GiaHH >= from);
            if (to.HasValue)
                allProducts = allProducts.Where(hh => hh.GiaHH <= to);
            #endregion

            #region Sorting
            allProducts = allProducts.OrderByDescending(x => x.TenHH);
            #endregion

            #region Paging
            allProducts = allProducts.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            #endregion

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
