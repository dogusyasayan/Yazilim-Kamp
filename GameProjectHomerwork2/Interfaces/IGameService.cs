using GameProjectHomerwork2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomerwork2.Interfaces
{
    interface IGameService
    {
        public void Add(Games game);
        public void Update(Games game);
        public void Delete(Games game);
    }
}
