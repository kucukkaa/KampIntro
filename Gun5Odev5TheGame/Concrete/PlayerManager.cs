using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Abstract;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;//??
        
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;//??
        }
        public void Delete(Player player)
        {
            Console.WriteLine(player.PlayerName + " deleted");
        }

        public void Save(Player player)
        {
            if (_playerCheckService.IsRealPerson(player))
            {
                Console.WriteLine(player.PlayerName + " successfully added");
            }
            else
            {
                Console.WriteLine(player.PlayerName + " can not be added. Please use valid user informations");
            }
        }

        public void Update(string newName,Player player)
        {
            var _tempName = player.PlayerName;
            player.PlayerName = newName;

            Console.WriteLine(_tempName + " updated to " + player.PlayerName);
        }
    }
}
