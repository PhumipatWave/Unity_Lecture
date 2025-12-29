using UnityEngine;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager instance { get; private set; }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SwitchScene()
    {
        Debug.Log("Switch Scene");
    }
}
