using System;
using System.Collections.Generic;
using UnityEngine;

namespace DataBoxing
{
    public class DataBoxing : MonoBehaviour
    {
        private event EventHandler OnSomethingHappened;

        private void Start()
        {
            int i = 10;
            // Data Boxing : Converting a value type to an object type (reference type)
            object o = i;

            // Unboxing
            i = (int)o;

            List<object> objectList = new List<object>
            {
                20,
                false,
                "Test"
            };

            OnSomethingHappened += Program_OnSomethingHappened;
        }

        private void Program_OnSomethingHappened(object sender, EventArgs e)
        {
            
        }
    }
}