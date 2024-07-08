using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URSAL_VINCENEIL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace URSAL_VINCENEIL.Controllers
{
  
    public class ClientApiController : ControllerBase
    {
        public readonly UrsalcoopContext _context;

        public ClientApiController(UrsalcoopContext context)
        {
            _context = context;
        }
          [HttpGet]
        public IActionResult GetClients()
        {
            try
            {
                var clients = _context.ClientsInfoTbs.ToList();

                if (clients.Any())
                {
                    return Ok(clients);
                }

                else
                {
                    return Ok("No records found");
                }
            }catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

    }
}