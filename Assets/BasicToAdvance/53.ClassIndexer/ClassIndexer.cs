using System;
using UnityEngine;

namespace ClassIndexer
{
    // Access data from your custome class as if it were an array
    public class ClassIndexer : MonoBehaviour
    {
        void Start()
        {
            PlayerStats playerStats = new PlayerStats
            {
                strAmount = 10,
                dexAmount = 15,
                wisAmount = 12
            };

            int strength = playerStats[PlayerStats.Stat.Str];
            Debug.Log(strength);
            playerStats[PlayerStats.Stat.Str] = 50;
            Debug.Log(playerStats[PlayerStats.Stat.Str]);
        }

        public class PlayerStats
        {
            public enum Stat
            {
                Str,
                Dex,
                Wis
            }

            public int strAmount;
            public int dexAmount;
            public int wisAmount;

            // public int this[any type, type2]
            public int this[Stat stat]
            {
                get
                {
                    switch (stat)
                    {
                        case Stat.Str:
                            return strAmount;
                        case Stat.Dex:
                            return dexAmount;
                        case Stat.Wis:
                            return wisAmount;
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (stat)
                    {
                        case Stat.Str:
                            strAmount = value; break;
                        case Stat.Dex:
                            dexAmount = value; break;
                        case Stat.Wis:
                            wisAmount = value; break;
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
            }
        }
    }
}