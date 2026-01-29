using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutines
{
    public class IEnumerables : MonoBehaviour
    {
        private void Start()
        {
            /*List<int> intList = new List<int>();
            Player player = new Player();

            // Foreach can't use value of custome type to do the operation
            foreach (int i in Player) { }*/

            PlayerStats playerStats = new PlayerStats();
            foreach (Stat stat in playerStats)
            {
                Debug.Log(stat);
            }
        }

        public class PlayerStats : IEnumerable<Stat>
        {
            public Stat dex = new Stat { name = "Dexterity", value = 12 };
            public Stat str = new Stat { name = "Strength", value = 20 };
            public Stat wis = new Stat { name = "Wisdom", value = 50 };

            public IEnumerator<Stat> GetEnumerator()
            {
                //return new PlayerStatEnumerator(this);

                // yield return : use if want to get some element
                yield return dex;
                yield return str;
                yield return wis;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public class PlayerStatEnumerator : IEnumerator<Stat>
            {
                // Recive player stats
                private PlayerStats playerStats;
                private int index;
                public PlayerStatEnumerator(PlayerStats playerStats)
                {
                    this.playerStats = playerStats;
                    // index default is -1
                    // because the foreach will call MoveNext before grab the Current
                    index = -1;
                }

                // Property
                public Stat Current
                {
                    // Grab the value base on index
                    get
                    {
                        switch (index)
                        {
                            default:
                            case 0: return playerStats.dex;
                            case 1: return playerStats.str;
                            case 2: return playerStats.wis;
                        }
                    }
                }

                object IEnumerator.Current => Current;

                // Don't want to defind the Dispose()
                public void Dispose() { }

                // Increase index
                public bool MoveNext()
                {
                    index++;

                    if (index > 2)
                    {
                        index = -1;
                    }
                    return index != -1;
                }

                public void Reset()
                {
                    index = -1;
                }
            }
        }

        public class Stat
        {
            public string name;
            public int value;

            public override string ToString()
            {
                return $"{name}, {value}";
            }
        }

        private class Player { }
    }
}