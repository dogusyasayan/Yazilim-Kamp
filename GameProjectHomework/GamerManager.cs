using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        
        public GamerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("Gamer Added");
            }
            else
            {
                Console.WriteLine("verification failed");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }
    }
}
