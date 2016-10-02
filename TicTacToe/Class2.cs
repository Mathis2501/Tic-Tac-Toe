using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Class2
    {
        char player = '';
        int ending = 0;
        char[] board = new char[3, 3];
        
        // show the board with numbers indicating what cordinat each slot has
        // tell the palyers to remember these cordinats as they will not be shown again

        while (ending == 0)
	{
            // show the currenct boards state

            if (player == 'x')
	{
            // check if there is 3 x's in a row on the board, if true decalre x winner, and set ending to 1
            // check if x already has 3 pieces on the board, if true ask for the cordiant of the one he wishes to move
            // ask for the codinat to the spot he wishes to place his piece at
            // change player to o
	}
            else // if player == o
	{
            // check if there is 3 o's in a row on the board, if true decalre o winner, and set ending to 1
            // check if o already has 3 pieces on the board, if true ask for the cordiant of the one he wishes to move
            // ask for the codinat to the spot he wishes to place his piece at
            // change player to x      
	}
	}
    }
}
