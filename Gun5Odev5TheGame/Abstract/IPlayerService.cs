using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);
        void Update(string newName, Player player);
        void Delete(Player player);
    }
}
