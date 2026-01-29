using System;
using UnityEngine;

namespace Events
{
    public class Events : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player();
            PlayerHealthBar playerHealthBar = new PlayerHealthBar(player);
            PlayerManaBar playerManaBar = new PlayerManaBar(player);
            player.Damage();
        }
    }

    public class Player
    {
        // event : like a delegate
        // event : is keyword can defind it to invoke the event only in this class of event
        public event Action OnPlayerDamaged;

        public void Damage()
        {
            if (OnPlayerDamaged != null)
            {
                OnPlayerDamaged();
            }
        }

        public class OnTestEventArgs : EventArgs
        {
            public int testIndex;
        }
        public event EventHandler<OnTestEventArgs> OnTestEventHandler;

        public void TestEventHandler()
        {
            //OnTestEventHandler(this, EventArgs.Empty);

            // ? : Null conditional operator use to check is null
            OnTestEventHandler?.Invoke(this, new OnTestEventArgs
            {
                testIndex = 2
            });
        }
    }

    public class PlayerTestEvent
    {
        public PlayerTestEvent(Player player)
        {
            // Subcribe event to the function
            // Events : need to unsubscribe on object is destroy or not use for protected memory leak
            player.OnTestEventHandler += Player_OnTestEventHandler; ;
        }

        private void Player_OnTestEventHandler(object sender, Player.OnTestEventArgs e)
        {
            e.testIndex = 100;
        }
    }

    public class PlayerHealthBar
    {
        public PlayerHealthBar(Player player)
        {
            // Subcribe event to the function
            // Events : need to unsubscribe on object is destroy or not use for protected memory leak
            player.OnPlayerDamaged += Player_OnPlayerDamaged;
        }

        private void Player_OnPlayerDamaged()
        {
            Debug.Log("Player_OnPlayerDamaged");
        }
    }

    public class PlayerManaBar
    {
        public PlayerManaBar(Player player)
        {
            // Subcribe event to the function
            player.OnPlayerDamaged += Player_OnPlayerDamaged;
        }

        private void Player_OnPlayerDamaged()
        {
            Debug.Log("Mana Bar Player_OnPlayerDamaged");
        }
    }
}