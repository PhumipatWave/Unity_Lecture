using UnityEngine;

public class Switch : MonoBehaviour
{
    private string name;

    void Start()
    {
        switch (name)
        {
            default:
                Debug.Log("Default");
                break;
            case "A":
                Debug.Log("Hello A.");
                break;
            case "X":
            case "Y":
                Debug.Log("Hello XY.");
                break;
        }
    }
}
