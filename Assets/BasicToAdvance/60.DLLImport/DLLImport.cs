using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DLLImport
{
    public class DLLImport : MonoBehaviour
    {
        // dll : Dynamic Link Library is the file that contains code other programs can use
        // DllImport : to import a function from a DLL
        // extern : this function is not defind anywhere in our program
        [DllImport("user32.dll")]
        public static extern bool MessageBeep(uint uType);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        private void Start()
        {
            MessageBeep(0);
            MessageBox(IntPtr.Zero, "Hello from Unity3D", "DLLImport", 0x00000004 | 0x00000020);
        }
    }
}