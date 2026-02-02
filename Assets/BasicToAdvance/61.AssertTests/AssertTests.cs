using UnityEngine;

namespace AssertTests
{
    // Assert Tests : Validate your code and a high level overview of Unit Testing
    public class AssertTests : MonoBehaviour
    {
        private void Start()
        {
            new Player(null);
        }

        public class Player
        {
            private string playerName;

            public Player(string playerName)
            {
                // Assert : like a breakpoint that triggers if the condition is false
                // It only be in debug configurations
                Debug.Assert(playerName != null);

                // This will be in builds
                //Trace.Assert(playerName != null);

                this.playerName = playerName;
            }
        }
    }
}