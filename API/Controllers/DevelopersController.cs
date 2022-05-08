using Domain.Entities;
using Domain.Interfaces;
using Domain.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        public readonly IGenericRepository<Developer> _repository;

        public DevelopersController(IGenericRepository<Developer> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var developers = await _repository.GetAllAsync();
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var developer = await _repository.GetByIdAsync(id);
            return Ok(developer);
        }

        [HttpGet("specify")]
        public async Task<IActionResult> Specify()
        {
            var specification = new DeveloperWithLevelNSpecification(3);
            //var specification = new DeveloperByProposedSalarySpecification();
            var developers = _repository.FindWithSpecificationPattern(specification);
            return Ok(developers);
        }
    }
}
