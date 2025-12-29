using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

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

    public void PlaySound()
    {
        Debug.Log("Play Sound");
    }

    public void StopSound()
    {
        Debug.Log("Stop Sound");
    }
}
