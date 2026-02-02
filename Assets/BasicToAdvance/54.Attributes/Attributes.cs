using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Attributes
{
    // Add metadata to your code
    public class Attributes : MonoBehaviour
    {
        // SerializeField Attribute : Makes private fields visible in inspector
        [SerializeField] private float moveSpeed;
        public MyClass myClass;

        private void Start()
        {
            object[] attributeObjectArray = typeof(Player).GetCustomAttributes(typeof(IsObjectTypeAttribute), false);

            IsObjectTypeAttribute isObjectTypeAttribute = (IsObjectTypeAttribute)attributeObjectArray[0];
            Debug.Log(isObjectTypeAttribute.GetObjectType());
        }

        // Obsolete Attribute: Marks the program elements that are no longer in use
        [Obsolete("Use the NewMove()")]
        private void OldMove() { }

        // DllImport Attribute: Import some external library
        //[DllImport]
    }

    [Serializable]
    public class MyClass
    {
        public int myInt;
        public string myString;
    }

    public enum ObjectType
    {
        Unit,
        Object,
        Prop
    }

    // Custom Attribute : Create your own attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class IsObjectTypeAttribute : System.Attribute
    {
        private ObjectType objectType;

        public IsObjectTypeAttribute(ObjectType objectType)
        {
            this.objectType = objectType;
        }

        public ObjectType GetObjectType()
        {
            return objectType;
        }
    }

    [IsObjectType(ObjectType.Unit)]
    public class Player { }
}