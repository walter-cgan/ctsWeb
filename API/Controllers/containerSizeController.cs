using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllersc
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContainerSizeController : ControllerBase
    {
        private readonly DataContext _context;
        public ContainerSizeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContainerSize>>> GetContainerSizes()
        {
            return await _context.ContainerSizes.ToListAsync();
        }
        
        // api/containersizes/3
        [HttpGet("{id}")]
        public async Task<ActionResult<ContainerSize>> GetContainerSize(int id)
        {
            return await _context.ContainerSizes.FindAsync(id);
        }
    }
}