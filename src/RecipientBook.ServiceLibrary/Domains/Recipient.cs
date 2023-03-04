using RecipientBook.ServiceLibrary.Entities;
using RecipientBook.ServiceLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipientBook.ServiceLibrary.Domains
{
    public class Recipient
    {
        public void SaveRecipient(RecipientEntity recipientEntity)
        {
            // Validate area

            var repository = new RecipientRepository();
            repository.SaveRecipientToDatabase(recipientEntity);
        }
    }
}
