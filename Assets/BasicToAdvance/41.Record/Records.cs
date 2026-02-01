using UnityEngine;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Records
{
    public class Records : MonoBehaviour
    {
        #region Example1
        private void Start()
        {
            // record : can only set in initialize
            Person person = new Person("Hello", "World");
            //person.FirstName = "UIIA";

            // non-destructive mutation
            // Create the new object override from the base
            Person person2 = person with { LastName = "Yo" };

            // record : can use for compare the data. but the normal class is reference type can't compare the data
            Debug.Log(person == person2);
        }

        // record : group the data into a type
        public record Person(string FirstName, string LastName);
        /*{
            // Techicle to change value in record but avoid to use this!
            public string FirstName {  get; set; } = FirstName;
        }*/

        public class PersonClass
        {
            // init : initialize, can't change the data (Immutable)
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }
        #endregion

        #region Example2
        public record Unit(float Speed);
        public record Player(string PlayerName, float Speed) : Unit(Speed);
        #endregion
    }
}