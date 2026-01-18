using UnityEngine;
using static Structs.Structs;

namespace Structs
{
    public class Structs : MonoBehaviour
    {
        #region Example1
        /*private void Start()
        {
            PlayerStruct playerStruct = new PlayerStruct();
            playerStruct.a = 1;
            PlayerClass playerClass = new PlayerClass();
            playerClass.a = 1;

            FunctionStruct(playerStruct);
            FunctionClass(playerClass);

            Debug.Log($"playerStruct : {playerStruct.a}\nplayerClass : {playerClass.a}");
        }

        private void FunctionStruct(PlayerStruct playerStruct)
        {
            playerStruct.a = 2;
        }

        private void FunctionClass(PlayerClass playerClass)
        {
            playerClass.a = 2;
        }

        public struct PlayerStruct
        {
            public int a;
        }

        public class PlayerClass
        {
            public int a;
        }*/
        #endregion

        #region Example2
        private void Start()
        {
            // Struct can use default to initialize
            Player player = default;
            Debug.Log(player);
        }

        // Struct is like a class but can't inheritance
        public struct Player //: MonoBehaviour
        {
            public int a;

            // Strct can use Constructor but only constructor with parameter
            public Player(int a)
            {
                this.a = a;
            }
        }
        #endregion
    }
}