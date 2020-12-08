using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    public class HelloController : ControllerBase
    {
        readonly IMapper _mapper;
        public HelloController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("/[controller]")]
        public ActionResult<UserDTO> Index()
        {
            var user = new User();
            var userDto = _mapper.Map<UserDTO>(user);
            return userDto;
        }
    }
}