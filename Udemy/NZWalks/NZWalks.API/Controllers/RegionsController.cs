using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTOs;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext _dbContext;
        private readonly IRegionRepository _IRegionRepository;
        private readonly IMapper _Imapper;

        public RegionsController(NZWalksDbContext dbContext, IRegionRepository regionRepository, IMapper mapper)
        {
            _dbContext = dbContext;
            _IRegionRepository = regionRepository;
            _Imapper = mapper;
        }
        // GET ALL REGIONS
        // GET: https://localhost:portnumber/api/regions
        [HttpGet]
        [Authorize(Roles = "Reader, Writer")]
        public async Task<IActionResult> GetAll()
        {
            // Domain Model -- Get data from Database
            var regionsDomain = await _IRegionRepository.GetAllAsync();

            // Map Domain Models to  DTOs
            var regionDTOs = _Imapper.Map<List<Region>>(regionsDomain);
            // return DTOs
            return Ok(regionDTOs);
        }

        // GET SINGLE REGION
        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader, Writer")]
        public async Task<IActionResult> GetByID([FromRoute]Guid id)
        {
            //var region = _dbContext.Regions.Find(id); // Ham find chi duoc su dung cho khoa chinh
            var regionDomain = await _IRegionRepository.GetByIdAsync(id); // ham firstordefault co the su dung cho cac thuoc tinh khac

            if(regionDomain == null)
            {
                return NotFound();
            }

            var regionDTO = _Imapper.Map<Region>(regionDomain);

            return Ok(regionDTO);
        }

        // POST: Create New Region
        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDTO addRegionRequestDTO)
        {
            // Map or Convert DTO to Domain Model
            var regionDomainModel = _Imapper.Map<Region>(addRegionRequestDTO);
            // Use Domain Model to create Model

            await _IRegionRepository.CreateAsync(regionDomainModel);

            // Map Domain Model to DTO
            var regionDTO = _Imapper.Map<Region>(regionDomainModel);
            return CreatedAtAction(nameof(GetByID), new
            {
                id = regionDTO.Id,
            }, regionDTO);
        }

        // Update region
        [HttpPut]
        [ValidateModel]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute]Guid id, [FromBody] UpdateRegionRequestDTO updateRegionRequestDTO)
        {
            var UpdateRegion = _Imapper.Map<Region>(updateRegionRequestDTO);
            var regionDomainModel = await _IRegionRepository.UpdateAsync(id, UpdateRegion);
            if (regionDomainModel == null)
            {
                return NotFound();
            }

            // Convert Domain Model to DTO
            var regionDTO = _Imapper.Map<RegionDto>(regionDomainModel);
            return Ok(regionDTO);     
        }

        // Delete
        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute]Guid id)
        {
            var regionDomainModel = await _IRegionRepository.DeleteAsync(id);
            if(regionDomainModel == null)
            {
                return NotFound();
            }

            // Map Domain Model to DTO
            var regionDTO = _Imapper.Map<RegionDto>(regionDomainModel);
            return Ok(regionDTO);
        }
    }
}
