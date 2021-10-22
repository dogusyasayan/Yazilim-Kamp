using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.GamerName == "Dogus" && gamer.GamerSurname == "Yasayan" & gamer.NationaltyIdentıty == 35719691652 && gamer.DateOfYear == 1997)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
