using System.Linq;
using UnityEngine;

namespace AnonymousTypes
{
    // Anonymous Types : structure some data without pre-defining a specific type
    public class AnonymousTypes : MonoBehaviour
    {
        private void Start()
        {
            // Anonymous Types : It's a property with readonly
            var message = new { Message = "Hello World" };
            var playerData = new { Name = "Old", Id = 30, message };

            Debug.Log(playerData.GetType());

            // Can't change value
            //playerData.Name = "D";

            var playerDataArray = new[]
            {
                // Anonymous Types : Must has the same property
                new { Name = "Player1", Team = "Red" },
                new { Name = "Player2", Team = "Blue" },
                new { Name = "Player3", Team = "Red" },
                new { Name = "Player4", Team = "Blue" }
            };

            // LINQ
            var redTeamArray = playerDataArray.Where(playerData => playerData.Team == "Red").Select(playerData => new { playerData.Name });
            foreach (var redTeam in redTeamArray)
            {
                Debug.Log(redTeam.Name);
            }
        }

        public class Player { }
    }
}