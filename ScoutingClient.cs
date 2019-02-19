using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace ScoutingAppData
{
    public class ScoutingClient
    {
        FirebaseClient Client;

        public ScoutingClient()
        {
            Client = new FirebaseClient("https://scoutingappstart.firebaseio.com/");
        }

        public async Task<Dictionary<string, string>> GetMatch(string Event, string Team, string Match)
        {
            string Path = "events/" + Event + "/teams/" + Team + "/matches/" + Match;
            Dictionary<string, string> Properties = await GetDictionary<string>(Path);
            Properties["event"] = Event;
            Properties["team"] = Team.ToString();
            Properties["match"] = Match.ToString();
            return Properties;
        }

        public async Task<object> GetData(string Event, string Team, string Match, string Data)
        {
            string Path = "events/" + Event + "/teams/" + Team + "/matches/" + Match + "/" + Data;
            ChildQuery Query = Client.Child(Path);
            return await Query.OnceSingleAsync<object>();
        }

        public async Task<List<string>> GetEvents()
        {
            return (await GetDictionary<object>("events")).Keys.ToList();
        }

        public async Task<List<string>> GetTeams(string Event)
        {
            return (await GetDictionary<object>("events/" + Event + "/teams")).Keys.ToList();
        }

        public async Task<List<string>> GetMatches(string Event, string Team)
        {
            return (await GetDictionary<object>("events/" + Event + "/teams/" + Team + "/matches")).Keys.ToList();
        }

        public async Task<Dictionary<string, T>> GetDictionary<T>(string Path)
        {
            OrderQuery Query = Client.Child(Path).OrderByKey();
            List<FirebaseObject<T>> Objects = (await Query.OnceAsync<T>()).ToList();
            Dictionary<string, T> D = new Dictionary<string, T>();
            foreach (FirebaseObject<T> Obj in Objects)
            {
                D.Add(Obj.Key, Obj.Object);
            }
            return D;
        }
    }
}
