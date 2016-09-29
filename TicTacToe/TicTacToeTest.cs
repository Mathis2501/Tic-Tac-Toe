using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToe
{
    [TestClass]
    public class TicTacToeTest
    {
        [TestMethod]
        public void NeitherPlayerHasThreeInARow()
        {
            IGameWinnerService gameWinnerService;
            const char expected = ' ';
            var gameboard = new char[3, 3] { {' ', ' ', ' '},
                                             {' ', ' ', ' '},
                                             {' ', ' ', ' '}};
            var actual = gameWinnerService.Validate(gameboard);
            Assert.AreEqual(expected, actual);
        }
    }
}
