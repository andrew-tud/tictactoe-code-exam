using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicTacToe.Business.Entities;
using TicTacToe.Business.Interface;

namespace TicTacToe.API.Controllers
{
    public class GameController : ApiController
    {
        private readonly IGame _iGame;
        public GameController()
        {
            //To IOC
        }

        public Player Post([FromBody] List<Position> positions)
        {
            TicTacToe.Business.TicTacToe ticTacToe = new TicTacToe.Business.TicTacToe();
            return ticTacToe.Play(positions);
        }
    }
}
