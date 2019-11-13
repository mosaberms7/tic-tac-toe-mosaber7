using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TicTacToe.Pages
{
    public enum Player
    {
        Blank=0,
        X='X',
        O='O'

    }
    public class ServerTicTacToeModel : PageModel
    {
        public Player Turn { get; protected set; } = Player.X;

        public Player[,] Board { get; protected set; } = new Player[3, 3];
        public Player winner { get; protected set; }

        public string State
        {
            get
            {
                string state = "";
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        switch (Board[x, y]) {
                            case Player.X:
                                state += "X";
                                break;
                            case Player.O:
                                state += "Y";
                                break;
                            case Player.Blank:
                                state += " ";
                                break;
                        }
              
                    }

                }
                return state;
            }
            set {
                for (int y = 0; y < 3; y++) {

                    for (int x = 0; x < 3; x++)
                    {
                        switch (value[3 * 3 + x]) {
                            case 'X':
                                Board[x, y] = Player.X;
                                break;
                            case 'O':
                                Board[x, y] = Player.O;
                                break;
                            case ' ':
                                Board[x, y] = Player.Blank;
                                break;
                    }
                    }


                }

            }
        }
        public void OnGet()
        {
            Board[2, 2] = Player.X;
        }
        public void onpost(string move) {
            string[] parts = move.Split("-");
            int x = int.Parse(parts[1]);
            int y = int.Parse(parts[2]);
            Board[x, y] = Turn;
            Turn = Turn == Player.X ? Player.O : Player.X;
        }
    }
}