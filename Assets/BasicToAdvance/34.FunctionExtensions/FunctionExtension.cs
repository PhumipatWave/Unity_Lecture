using UnityEngine;

namespace FunctionExtension
{
    public class FunctionExtension : MonoBehaviour
    {
        private void Start()
        {
            MyTranform myTranform = null;
            myTranform.MoveRight();

            // This two pattern is the same
            transform.MoveRight(3f);
            //TransformExtension.MoveRight(transform);

            bool b = false;
            b.IsTrue();
        }
    }

    // Extension : use to create more method of target type
    // by not modify the base of it
    // Extension : must be public and static
    public static class TransformExtension
    {
        // The this keyword in parameter mean
        // the parameter of this method is a type that assign this method
        public static void MoveRight(this Transform transform, float amount)
        {
            transform.position += new Vector3(1, 0, 0) * amount;
        }

        public static bool IsTrue(this bool b)
        {
            return b;
        }
    }

    public class MyTranform
    {
        public Vector3 position;

        public void MoveRight()
        {
            position += new Vector3(1, 0, 0);
        }
    }
}