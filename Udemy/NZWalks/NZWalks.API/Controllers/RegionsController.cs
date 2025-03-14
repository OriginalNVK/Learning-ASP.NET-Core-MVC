using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
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
            return Ok(regionDTOs);
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
        public IActionResult Create([FromBody] AddRegionRequestDTO addRegionRequestDTO)
        {
            // Map or Convert DTO to Domain Model
            var regionDomainModel = new Region
            {
                Code = addRegionRequestDTO.Code,
                Name = addRegionRequestDTO.Name,
                RegionImageUrl = addRegionRequestDTO.RegionImageUrl,
            };
            // Use Domain Model to create Model

            _dbContext.Regions.Add(regionDomainModel);
            _dbContext.SaveChanges();

            // Map Domain Model to DTO
            var regionDTO = new RegionDto
            {
                Id = regionDomainModel.Id,
                Name = regionDomainModel.Name,
                Code = regionDomainModel.Code,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };
            return CreatedAtAction(nameof(GetByID), new
            {
                id = regionDTO.Id,
            }, regionDTO);
        }

        // Update region
        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult Update([FromRoute]Guid id, [FromBody] UpdateRegionRequestDTO updateRegionRequestDTO)
        {
            var regionDomainModel = _dbContext.Regions.FirstOrDefault(r => r.Id == id);
            if(regionDomainModel  == null)
            {
                return NotFound();
            }
            // Map DTO to Domain Model
            regionDomainModel.Code = updateRegionRequestDTO.Code;
            regionDomainModel.Name = updateRegionRequestDTO.Name;
            regionDomainModel.RegionImageUrl = updateRegionRequestDTO.RegionImageUrl;

            _dbContext.SaveChanges();

            // Convert Domain Model to DTO
            var regionDTO = new RegionDto
            {
                Id = regionDomainModel.Id,
                Name = regionDomainModel.Name,
                Code = regionDomainModel.Code,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };
            return Ok(regionDTO);
        }

        // Delete
        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult Delete([FromRoute]Guid id)
        {
            var regionDomainModel = _dbContext.Regions.FirstOrDefault(r => r.Id==id);
            if(regionDomainModel == null)
            {
                return NotFound();
            }
            // Delete the region
            _dbContext.Remove(regionDomainModel);
            _dbContext.SaveChanges();

            // Map Domain Model to DTO
            var regionDTO = new RegionDto
            {
                Id = regionDomainModel.Id,
                Name = regionDomainModel.Name,
                Code = regionDomainModel.Code,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };
            return Ok(regionDTO);
        }
    }
}
