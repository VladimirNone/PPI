using DbManager.Data.Relations;
using Newtonsoft.Json;

namespace DbManager.Data.Nodes
{
    public class Client : User, INode
    {
        public float Bonuses { get; set; }

        public string Some { get; set; } = "Какая-то осознанная чушь";
        public string Some1 { get; set; } = "Какая-то осознанная чушь 1";
        public string Some2 { get; set; } = "Какая-то осознанная чушь 2";
        public string Some3 { get; set; } = "Какая-то осознанная чушь 3";

        [JsonIgnore]
        public List<Ordered>? ClientOrders { get; set; }
    }
}
