using FoodBook.Api.BusinessLogic;
using FoodBook.Api.DataAccess;
using FoodBook.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult AddNewRecipient(RecipientModel recipientModel)
        {
            var businessLogic = new RecipientBusinessLogic();
            businessLogic.SaveRecipient(recipientModel);
            return Ok();
        }
     
        }
       
    }


      
    


