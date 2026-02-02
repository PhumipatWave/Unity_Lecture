using System;
using UnityEngine;

namespace UnsafePointers
{
    // Bypass C# safety features and work with raw memory
    public class UnsafePointers : MonoBehaviour
    {
        private void Start()
        {
            // unsafe : Allows code that uses pointers
            unsafe
            {
                // * Pointer : Holds the memory address (Location) of a value
                // stackalloc : Allocates a block of memory on the stack
                int* intArrayPtr  = stackalloc int[10];
                // move pointer to index 5
                intArrayPtr += 15; 

                // unsafe : if make out of bound it not break the execution
                for (int i = 0; i < 10; i++)
                {
                    Debug.Log(intArrayPtr[i]);
                }

                Debug.Log(((IntPtr)intArrayPtr).ToString("x"));

                GameData gameData = new GameData();
                // & Address-of operator : Gets the memory address of a variable
                GameData* gameDataPtr = &gameData;

                // -> Member access operator : Gets member of object in pointer
                gameDataPtr->coins = 12;
                gameDataPtr->isGameOver = false;

                int a = 5;
                PowerTwo(&a);
                Debug.Log(a);

                byte[] bytes = new byte[] { 1, 2, 3, 4, 5 };
                // fixed : Generates a fixed pointer to a managed variable
                fixed (byte* bytePtr = bytes)
                {
                    
                }
            }
        }

        public struct GameData
        {
            public int coins;
            public bool isGameOver;
        }

        public static unsafe void PowerTwo(int* value)
        {
            // Dereference operator (*) : Gets value at the address in a pointer
            *value *= *value;
        }
    }
}