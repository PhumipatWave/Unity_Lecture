using System;
using System.Reflection;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private void Start()
    {
        // Normal call the function of class
        Exercise exercise = new Exercise();
        exercise.MyFunction();


        // Reflection : use to test if something exits before that thing actually exits
        MethodInfo myFunctionMethodInfo = typeof(Exercise).GetMethod("MyFunction");
        myFunctionMethodInfo.Invoke(exercise, new object[] { });

        if (myFunctionMethodInfo != null) { }

        Type playerType = typeof(Exercise).GetNestedType("Player");
        Debug.Log(playerType);

        // BindingFlags : condition type of class
        // | : it a or operation of BindingFlags
        foreach (Type type in typeof(Exercise).GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Static))
        {
            Debug.Log(type);
        }

        object playerObject = Activator.CreateInstance(playerType);
        MethodInfo methodInfo = playerType.GetMethod("MyFunction");
        methodInfo.Invoke(playerObject, new object[] { 100 });

        // Reflection : can use to test private method by not direct the method
        MethodInfo privateMethodInfo = playerType.GetMethod("MyPrivateFunction", BindingFlags.NonPublic | BindingFlags.Instance);
        privateMethodInfo.Invoke(playerObject, new object[] { 25 });

        Debug.Log(typeof(Reflection).Assembly);

        foreach (Type type in typeof(Reflection).Assembly.GetTypes())
        {
            Debug.Log(type);
        }
    }

    public class Exercise
    {
        public void MyFunction() 
        {
            Debug.Log("MyFunction");
        }

        private class Unit { }
        public class Player 
        {
            private void MyPrivateFunction(int i)
            {
                Debug.Log($"My Plivate Player Function {i}");
            }

            public void MyFunction(int i)
            {
                Debug.Log($"My Player Function {i}");
            }
        }
        public class Enemy { }
    }
}
