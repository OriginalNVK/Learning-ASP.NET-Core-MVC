using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Services
{
    public class LoaiRepository : ILoaiRepository
    {
        private readonly WebDbContext _dbContext;

        public LoaiRepository(WebDbContext dbContext) { 
            _dbContext = dbContext;
        }
        public LoaiVM Add(LoaiModel loai)
        {
            var Loai = new Loai()
            {
                TenLoai = loai.TenLoai
            };
            _dbContext.Loais.Add(Loai);
            _dbContext.SaveChanges();
            return new LoaiVM
            {
                MaLoai = Loai.MaLoai,
                TenLoai = Loai.TenLoai
            };
        }

        public void Delete(int id)
        {
            var Loai = _dbContext.Loais.FirstOrDefault(x => x.MaLoai == id);
            if (Loai != null)
            {
                _dbContext.Loais.Remove(Loai);  
                _dbContext.SaveChanges() ;
            }
        }

        public List<LoaiVM> GetAll()
        {
            var loais = _dbContext.Loais.Select(x => new LoaiVM()
            {
                MaLoai = x.MaLoai,
                TenLoai = x.TenLoai,
            }).ToList();
            return loais;
        }

        public LoaiVM GetById(int id)
        {
            var Loai = _dbContext.Loais.FirstOrDefault(x => x.MaLoai == id);
            if (Loai != null)
            {
                var loaiVM = new LoaiVM()
                {
                    MaLoai = id,
                    TenLoai = Loai.TenLoai
                };
                return loaiVM;
            }

            return null;
        }

        public void Update(LoaiVM loai)
        {
            var Loai = _dbContext.Loais.FirstOrDefault(x => x.MaLoai == loai.MaLoai);
            Loai.TenLoai = loai.TenLoai;
            _dbContext.SaveChanges();
        }

        public List<LoaiVM> GetAllLoai(string search)
        {
            var Loai = _dbContext.Loais.AsQueryable();
            if(!string.IsNullOrEmpty(search)) {
                Loai = Loai.Where(x => x.TenLoai.Contains(search));
            }

        }
    }
}
