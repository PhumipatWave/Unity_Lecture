using System;
using System.IO;
using UnityEngine;

namespace IDisposables
{
    // IDisposables : Add support for 'using' code block to your custom classes for clean up
    public class IDisposables : MonoBehaviour
    {
        private void Start()
        {
            // IDisposable : use for automatic resource management and clean up
            /*using (FileStream fileStream = File.Open("myFile.txt", FileMode.Open))
            {
                fileStream.Read(new Span<byte>());
            }*/

            using (SaveSystem saveSystem = new SaveSystem())
            {
                saveSystem.SavePlayerData();
                saveSystem.SaveObjectData();
            }
        }

        public class SaveSystem : IDisposable
        {
            private FileStream fileStream;
            public SaveSystem()
            {
                fileStream = File.Open("saveFile.save", FileMode.Open);
            }

            public void SavePlayerData()
            {
                // fileStream
            }

            public void SaveObjectData()
            {
                // fileStream
            }

            public void Dispose()
            {
                fileStream.Dispose();
                Debug.Log("Dispose");
            }

            ~SaveSystem()
            {
                Dispose();
            }
        }
    }
}