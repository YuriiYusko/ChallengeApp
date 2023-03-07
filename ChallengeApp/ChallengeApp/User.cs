using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class User
    {
        public static string gameName = "Diablo";
        private List<int> score;
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            this.score = new List<int>();
        }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public int Result
        {
            get { return this.score.Sum(); }
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }
    }
}
