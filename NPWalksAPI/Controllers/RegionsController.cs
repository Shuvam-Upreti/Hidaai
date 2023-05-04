using HidaaiAPI.Data;
using HidaaiAPI.Models.Domain;
using HidaaiAPI.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HidaaiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly HidaaiDbContext dbContext;

        public RegionsController(HidaaiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            //Get data from Database- Domain Model
            var regionsDomain = dbContext.Regions.ToList();

            //Map Domain model to DTOs
            var regionsDto = new List<RegionDto>();
            foreach(var regionDomain in regionsDomain)
            {
                regionsDto.Add(new RegionDto()
                {
                    Id= regionDomain.Id,
                    Code=regionDomain.Code,
                    Name=regionDomain.Name,
                    RegionImageUrl=regionDomain.RegionImageUrl
                });
            }

            //return DTOs
            return Ok(regionsDto);
        }


        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            //Get from domain model
            var regionDomain = dbContext.Regions.FirstOrDefault(x =>x.Id==id);
            if (regionDomain == null)
            {
                return NotFound(); 
            }

            //Map Domain to Dto
            var regionDto = new RegionDto
            {
                Id = regionDomain.Id,
                Code = regionDomain.Code,
                Name = regionDomain.Name,
                RegionImageUrl = regionDomain.RegionImageUrl
            };

            //return dto
            return Ok(regionDto);

        }
    }
}
