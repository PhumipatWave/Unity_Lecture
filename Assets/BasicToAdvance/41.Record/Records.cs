using UnityEngine;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Records
{
    public class Records : MonoBehaviour
    {
        private void Start()
        {
            // record : can only set in initialize
            Person person = new Person("Hello", "World");
            //person.FirstName = "UIIA";

            // non-destructive mutation
            // Create the new object override from the base
            Person person2 = person with { LastName = "Yo" };

            Debug.Log(person);
            Debug.Log(person2);
        }

        public record Person(string FirstName, string LastName);
        /*{
            // Techicle to change value in record but avoid to use this!
            public string FirstName {  get; set; } = FirstName;
        }*/

        public class PersonClass
        {
            public string FirstName {  get; init; }
            public string LastName { get; init; }
        }
    }
}