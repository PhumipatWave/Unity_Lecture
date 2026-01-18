using System;
using System.Collections.Generic;
using UnityEngine;

public class UnityDictionary : MonoBehaviour
{
    public enum ResorceType
    {
        Wood,
        Stone,
        Iron
    }

    [SerializeField] private Dictionary<ResorceType, int> resourceTypeAmountDictionary;

    [Serializable]
    public class ResourseTypeAmount
    {
        public ResorceType resorceType;
        public int amount;
    }
    [SerializeField] private List<ResourseTypeAmount> resourseTypeAmountList;

    void Start()
    {
        resourceTypeAmountDictionary = new Dictionary<ResorceType, int>();

        foreach (ResourseTypeAmount resourseTypeAmount in resourseTypeAmountList)
        {
            resourceTypeAmountDictionary[resourseTypeAmount.resorceType] = resourseTypeAmount.amount;
        }

        Debug.Log("Unity Dictionary :");
        foreach (ResorceType resorceType in resourceTypeAmountDictionary.Keys)
        {
            Debug.Log($"{resorceType} : {resourceTypeAmountDictionary[resorceType]}");
        }
    }
}
