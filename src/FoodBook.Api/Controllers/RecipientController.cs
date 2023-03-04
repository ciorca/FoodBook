
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipientBook.ServiceLibrary.Domains;
using RecipientBook.ServiceLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipientController : ControllerBase
    {
        [HttpGet]
       
        public IActionResult AddNewRecipient([FromQuery]RecipientEntity recipientEntity)
        {
            
            var businessLogic = new Recipient();
            businessLogic.SaveRecipient(recipientEntity);
            return Ok();
        }
     
        }
       
    }


      
    


