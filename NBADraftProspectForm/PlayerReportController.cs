using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftProspectForm
{
    public class PlayerReportController
    {
        private List<PlayerReport> players;

        public PlayerReportController()
        {
            players = null;
        }

        public PlayerReportController(List<PlayerReport> players)
        {
            this.players = players;
        }

        public void AddPlayer(string name, string school, int year, int level, int height, int weight, List<int> pos, string notes)
        {
            PlayerReport playerReport = new PlayerReport(name, school, year, level, height, weight, pos, notes);
            players.Add(playerReport);
       
        }

        public string GetPlayersAsString()
        {
            string result = "";
            foreach (PlayerReport player in players)
            {
                result = result + player + "\n";
            }
            return result;
        }
        public List<string> GetPlayerNames()
        {
            List<string> result = new List<string>();
            foreach(PlayerReport player in players)
            {
                result.Add(player.Name);
            }
            return result;
        }

        public Dictionary<string,string> GetDataForPlayerName(string name)
        {
            Dictionary<string,string> data = new Dictionary<string, string>();
            string posString;
            foreach(PlayerReport player in players)
            {
                if (player.Name.Equals(name))
                {
                    data.Add("name", player.Name);
                    data.Add("school", player.School);
                    data.Add("year", Convert.ToString(player.Year));
                    data.Add("level", Convert.ToString(player.Level));
                    data.Add("height", Convert.ToString(player.Height));
                    data.Add("weight", Convert.ToString(player.Weight));
                    posString = "";
                    if (player.Positions.Contains(0))
                    {
                        posString = posString + "0 ";
                    }
                    if (player.Positions.Contains(1))
                    {
                        posString = posString + "1 ";
                    }
                    if (player.Positions.Contains(2))
                    {
                        posString = posString + "2 ";
                    }
                    if (player.Positions.Contains(3))
                    {
                        posString = posString + "3 ";
                    }
                    if (player.Positions.Contains(4))
                    {
                        posString = posString + "4 ";
                    }
                    posString = posString.Trim();
                    data.Add("pos", posString);
                    data.Add("notes", player.Notes);
                    return data;
                }
            }
            return null;
        }
    }
}
