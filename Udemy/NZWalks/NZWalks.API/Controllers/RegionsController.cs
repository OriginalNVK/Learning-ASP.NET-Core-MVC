using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.DTOs;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext _dbContext;

        public RegionsController(NZWalksDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        // GET ALL REGIONS
        // GET: https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            // Domain Model -- Get data from Database
            var regionsDomain = _dbContext.Regions.ToList();

            // Map Domain Models to  DTOs
            var regionDTOs = new List<RegionDto>();
            foreach(var region in regionsDomain)
            {
                regionDTOs.Add(new RegionDto()
                {
                    Id = region.Id,
                    Name = region.Name,
                    Code = region.Code,
                    RegionImageUrl = region.RegionImageUrl,
                });
            }
            // return DTOs
            return Ok(regions);
        }

        // GET SINGLE REGION
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetByID([FromRoute]Guid id)
        {
            //var region = _dbContext.Regions.Find(id); // Ham find chi duoc su dung cho khoa chinh
            var regionDomain = _dbContext.Regions.FirstOrDefault(r => r.Id == id); // ham firstordefault co the su dung cho cac thuoc tinh khac

            if(regionDomain == null)
            {
                return NotFound();
            }

            var regionDTO = new RegionDto()
            {
                Id = regionDomain.Id,
                Name = regionDomain.Name,
                Code = regionDomain.Code,
                RegionImageUrl = regionDomain.RegionImageUrl,
            };

            return Ok(regionDTO);
        }

        // POST: Create New Region
        [HttpPost]
        public IActionResult Create()
        {

        }
    }
}
