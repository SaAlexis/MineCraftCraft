using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mine2Craft.Test.Dtos;
using Mine2Craft.Test.Entities;
using Mine2Craft.Test.Persistance;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mine2Craft.Test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IGenericRepository<ItemEntity> _itemRepository;
        private IMapper _mapper;

        public ItemController(IGenericRepository<ItemEntity> userRepository, IMapper mapper)
        {
            _itemRepository = userRepository;
            _mapper = mapper;
        }

         // GET: api/<ItemController>
        [HttpGet]
        public ActionResult Get()
        {
            var usersEntity = _itemRepository.GetAll();
            var dto = _mapper.Map<IEnumerable<ItemDto>>(usersEntity);
            return Ok(dto);
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ItemController>
        [HttpPost]
        public IActionResult Post([FromBody] ItemDto itemDto)
        {
            var itemEntity = _mapper.Map<ItemEntity>(itemDto);
            _itemRepository.Add(itemEntity);
    
            return Ok(CreatedAtAction(nameof(Get), new {id = itemEntity.Id}, itemEntity));
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
