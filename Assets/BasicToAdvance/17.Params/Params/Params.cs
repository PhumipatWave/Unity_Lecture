using UnityEngine;

namespace Params
{
    public class Params : MonoBehaviour
    {
        void Start()
        {
            // Params can be null and not error
            PrintPlayerName(13);
        }

        // Params must be array and must be lasted parameter
        private void PrintPlayerName(int age, params string[] playerNameArray)
        {
            Debug.Log(playerNameArray.Length);
        }
    }
}