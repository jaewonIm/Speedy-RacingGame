using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class RankManager : MonoBehaviour
{
    public static RankManager instance;
    
    public Text[] txtRanks;

    Dictionary<string, Player> players;
    Dictionary<string, Player> sortedPlayers;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
        players = new Dictionary<string, Player>();
    }

    // Set player rank in UI text   
    public void SetRank(Player player)
    {
        players[player.name] = player;
        IOrderedEnumerable<KeyValuePair<string, Player>> sortedPlayer = players.OrderBy(x => x.Value.distanceToWaypoint).OrderByDescending(x => x.Value.activeWaypointIndex);
        int i = 0;
        foreach (KeyValuePair<string, Player> item in sortedPlayer)
        {
            if (i == 0) txtRanks[i].text = item.Value.name;
            if (i == 1) txtRanks[i].text = item.Value.name;
            if (i == 2) txtRanks[i].text = item.Value.name;
            if (i == 3) txtRanks[i].text = item.Value.name;
            i++;
        }
    }
}
