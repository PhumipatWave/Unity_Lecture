using System;
using UnityEngine;

public class Naming : MonoBehaviour
{
    // Constants : UpperCase SnakeCase
    public const int CONSTANT_FIELD = 69;

    // Properties : PascalCase 
    public static Naming Instance { get; private set; }

    // Event : PascalCase 
    public event EventHandler OnSomethingHappened;

    // Fields : CamelCase 
    private float memberVariable;

    // Function : PascalCase 
    private void Awake()
    {
        Instance = this;
        DoSomething(50f);
    }

    // Function Params : CamelCase 
    private void DoSomething(float time)
    {
        memberVariable = time;
        //.....
    }
}
