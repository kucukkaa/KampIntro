using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame.Abstract
{
    public interface IPlayerCheckService
    {
        bool IsRealPerson(Player player);
    }
}
