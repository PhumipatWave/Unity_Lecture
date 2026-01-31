using UnityEngine;

public class Defaults : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(new Box<int>().GetDefault());
        Debug.Log(new Box<bool>().GetDefault());
        Debug.Log(new Box<Player>().GetDefault());
    }

    public class Box<T>
    {
        public T GetDefault()
        {
            // default : return the default value of type
            return default(T);
        }
    }

    public class Player { }
}
