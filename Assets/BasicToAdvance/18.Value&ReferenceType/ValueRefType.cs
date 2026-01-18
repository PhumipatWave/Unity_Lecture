using System;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

namespace ValueReferenceType
{
    // Value Type : Contain the Data
    // int, float, bool, enum, struct

    // Reference Type : Stores References to Data
    // class, object, array, string

    #region Example1
    /*public class ValueRefType : MonoBehaviour
    {
        void Start()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.a = 5;
            MyStruct mySecondStruct = myStruct;
            mySecondStruct.a = 10;
            Debug.Log($"myStruct : {myStruct.a}, mySecondStruct : {mySecondStruct.a}");

            MyClass myClass = new MyClass();
            myClass.a = 5;
            MyClass mySecondClass = myClass;
            mySecondClass.a = 10;
            Debug.Log($"myClass : {myClass.a}, mySecondClass : {mySecondClass.a}");
        }
    }

    public struct MyStruct
    {
        public int a;
    }

    public class MyClass
    {
        public int a;
    }*/
    #endregion

    #region Example2
    public class ValueRefType : MonoBehaviour
    {
        void Start()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.a = 10;
            MyClass myClass = new MyClass();
            myClass.a = 10;

            MyFunction(myClass, myStruct);

            Debug.Log($"myStruct : {myStruct.a}, myClass : {myClass.a}");

        }

        // Class can pass to modify the value by reference
        // But Struct can't modify only copy the data but no relation to define the actual data
        public void MyFunction(MyClass myClass, MyStruct myStruct)
        {
            myClass.a = 5;
            myStruct.a = 5;
        }

        public void ValueRefNull()
        {
            // Value Type : Value can't be null
            // int x = null;

            // But can use Nullable to be null
            Nullable<int> x = null;

            // Reference Type : Value can null
            int[] a = null;
        }
    }

    public struct MyStruct
    {
        public int a;
    }

    public class MyClass
    {
        public int a;
    }
    #endregion
}