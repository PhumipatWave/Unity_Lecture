using UnityEngine;
using System;

// Can defind the name and assign to the function of target namespace
using UnityRandom = UnityEngine.Random;

// namespace : use for split the system and protected the same class name
namespace Namespaces
{
    public class Program : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player();
            Test.Player testPlayer;
            Test.PlayerT.Player testPlayerT;

            // This Random system error because it has in UnityEngine and System namespace
            //Random.Range(0, 1);

            UnityRandom.Range(0, 1);
        }

        public class Player
        {

        }
    }
}

namespace Test
{
    public class Player
    {

    }
}

namespace Test.PlayerT
{
    public class Player
    {

    }
}