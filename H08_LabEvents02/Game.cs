using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents02
{
    public class Game
    {
        public Game(IPlayer p1, IPlayer p2) {
            Player1 = p1;
            Player2 = p2;
        }
        //Player winner = g.Start();
        public IPlayer Start() {
            int p1_result = Player1.Play();
            int p2_result = Player2.Play();
            if (p1_result > p2_result) {
                return Player1;
            } else {
                if (p2_result > p1_result) {
                    return Player2;
                } else {
                    return null;
                }
            }
        }

        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }
    }
}
