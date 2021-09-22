using ContactRepository.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using ContactRepository.Models;
using System.Threading.Tasks;

namespace ContactRepository.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class ContactController : ControllerBase
    {
        IContactsRepository IcontactRepository;
        public ContactController(IContactsRepository _IcontactRepository)
        {
            IcontactRepository = _IcontactRepository;
        }
        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            if(contact==null)
            {
                return BadRequest();
            }
            await IcontactRepository.Add(contact);
            return Ok(contact);
        }
    }
}