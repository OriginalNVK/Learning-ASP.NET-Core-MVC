using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTOs;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository _IWalkRepository;

        public WalksController(IMapper mapper, IWalkRepository iWalkRepository) { 
            this.mapper = mapper;
            this._IWalkRepository = iWalkRepository;
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalkRequestDto)
        {
            // Map DTO to Domain Model
            var walkDomainModel = mapper.Map<Walk>(addWalkRequestDto);

            await _IWalkRepository.CreateAsync(walkDomainModel);

            // Map domain model to Dto


            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var WalksDomainModel = await _IWalkRepository.GetAllAsync();

            // map Domain to Dto

            return Ok(mapper.Map<List<WalkDto>>(WalksDomainModel));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var DomainWalk = await _IWalkRepository.GetByIdAsync(id);
            if(DomainWalk == null)
            {
                return NotFound();
            }
            return Ok(DomainWalk);
        }

        [HttpPut]
        [ValidateModel]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, UpdateWalkRequestDTO updateWalkRequestDTO)
        {
            var Walk = mapper.Map
            <Walk>(updateWalkRequestDTO);
            Walk = await _IWalkRepository.UpdateAsync(id, Walk);

            if (Walk == null)
            {
                return NotFound();
            }

            var WalkDto = mapper.Map<WalkDto>(Walk);
            return Ok(WalkDto);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleteWalk = await _IWalkRepository.DeleteAsync(id);
            if(deleteWalk == null)
            {
                return NotFound();
            }
            var deleteWalkDto = mapper.Map<WalkDto>(deleteWalk);
            return Ok(deleteWalkDto);
        }
    }
}
