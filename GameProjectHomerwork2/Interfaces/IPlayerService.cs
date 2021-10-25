using GameProjectHomerwork2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomerwork2.Interfaces
{
    interface IPlayerService
    {
        public void Add(Games game);
        public void Update(Games game);
        public void Delete(Games game);
    }
}
