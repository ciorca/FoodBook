using FoodBook.Api.DataAccess;
using FoodBook.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBook.Api.BusinessLogic
{
    public class RecipientBusinessLogic
    {
        public void SaveRecipient(RecipientModel recipientModel)
        {
            // Validate area

            var dataAccess = new RecipientDataAccess();
            dataAccess.SaveRecipientToDatabase(recipientModel);
        }
    }
}
