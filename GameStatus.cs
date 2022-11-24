using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number {
    internal class GameStatus {
        public int
            lives = 0,
            score = 0,

            tries_global = 0,
            tries_local = 0,
            avg_tries = 0,
            max_tries = 0,
            min_tries = 100;

        public string
            info = "",
            usedNums = "";

        public GameStatus(int _lives, int _tries_global, int _tries_local, int _avg_tries, int _max_tries, int _min_tries, int _score, string _info, string _usedNums) {
            this.lives = _lives;
            this.tries_global = _tries_global;
            this.tries_local = _tries_local;
            this.avg_tries = _avg_tries;
            this.max_tries = _max_tries;
            this.min_tries = _min_tries;
            this.score = _score;
            this.info = _info;
            this.usedNums = _usedNums;
        }
    }
}