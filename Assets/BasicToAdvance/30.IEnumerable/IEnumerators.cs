using System.Collections;
using UnityEngine;

namespace Coroutines
{
    public class IEnumerators : MonoBehaviour
    {
        private void Start()
        {
            // Call the coroutine
            StartCoroutine(MyCoroutine());
        }

        // IEnumerator : Use for control the game time
        private IEnumerator MyCoroutine()
        {
            Debug.Log("Before");
            yield return new WaitForSeconds(3f);
            Debug.Log("After time");
        }
    }
}