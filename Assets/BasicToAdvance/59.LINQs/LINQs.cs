using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Xml.Linq;

namespace LINQs
{
    // LINQ : Easily do queries on your data collections
    public class LINQs : MonoBehaviour
    {
        private void Start()
        {
            List<Player> playerList = new List<Player>()
            {
                new Player() { playerName = "Player1", team = "Red" },
                new Player() { playerName = "Player2", team = "Blue" },
                new Player() { playerName = "Player3", team = "Red" },
                new Player() { playerName = "Player4", team = "Blue" },
            };

            // LINQ Method Syntax
            /*List<Player> redPlayerList = playerList.Where(player => player.team == "Red").ToList();
            foreach (Player player in redPlayerList)
            {
                Debug.Log(player);
            }*/

            // LINQ Method Second Syntax
            // Select * From playerList Where team = "Red"
            IEnumerable<Player> redPlayerEnumerable =
                from player in playerList
                where player.team == "Red"
                select player;

            foreach (Player player in redPlayerEnumerable)
            {
                Debug.Log(player);
            }

            // XML Example
            XElement contacts = XElement.Load(@"c:\myContactList.xml");
            var data =
                from contact in contacts.Elements("Record")
                from field in contact.Elements("Field")
                where field.Value == "Target"
                select contact;
        }

        public class Player
        {
            public string playerName;
            public string team;

            public override string ToString()
            {
                return $"{playerName}, {team}";
            }
        }
    }
}