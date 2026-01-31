using System.Runtime.InteropServices;
using UnityEngine;

namespace SizeOf
{
    public class SizeOf : MonoBehaviour
    {
        private void Start()
        {
            int i = 5;

            // sizeof : Get size of type
            Debug.Log(sizeof(int));
            Debug.Log(Marshal.SizeOf(new Player()));
        }

        [StructLayout(LayoutKind.Sequential)]
        public class Player
        {
            public int speed;

            public bool IsGrounded()
            {
                return true;
            }
        }
    }
}