using System.Collections.Generic;
using UnityEngine;

namespace Dictionarys
{
    public class Dictionarys : MonoBehaviour
    {
        private enum ResorceType
        {
            Wood,
            Stone,
            Iron
        }

        void Start()
        {
            Dictionary<ResorceType, int> resourceTypeAmountDictionary = new Dictionary<ResorceType, int>()
            {
                { ResorceType.Wood, 10 },
                { ResorceType.Stone, 25 },
                { ResorceType.Iron, 0 }
            };

            //resourceTypeAmountDictionary.Add(ResorceType.Stone, 3);
            if (resourceTypeAmountDictionary.ContainsKey(ResorceType.Stone))
            {
                Debug.Log($"Stone amount : {resourceTypeAmountDictionary[ResorceType.Stone]}");
            }

            //resourceTypeAmountDictionary.Add(ResorceType.Wood, 10);
            // If dictionary don't has any item it pass not error
            if (resourceTypeAmountDictionary.TryGetValue(ResorceType.Wood, out int woodAmount))
            {
                Debug.Log($"Wood amount : {woodAmount}");
            }

            foreach (KeyValuePair<ResorceType, int> keyValuePair in resourceTypeAmountDictionary)
            {
                Debug.Log($"{keyValuePair.Key} : {keyValuePair.Value}");
            }

            /*foreach (ResorceType resorceType in resourceTypeAmountDictionary.Keys)
            {
                Debug.Log($"{resorceType} : {resourceTypeAmountDictionary[resorceType]}");
            }*/
        }
    }
}