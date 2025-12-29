using UnityEngine;

public class AbillityRunner : MonoBehaviour
{
    
}

public interface IAbility
{
    void Use();
}

public class RageAbility : IAbility
{
    public void Use()
    {
        throw new System.NotImplementedException();
    }
}