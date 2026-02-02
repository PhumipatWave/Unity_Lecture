using UnityEngine;

namespace Tuples
{
    // Tuples : Structure some data without defining a type
    public class Tuples : MonoBehaviour
    {
        private void Start()
        {
            #region Example1
            // Tuple : is normal field it can read and write data
            /*var myTuple = (name:"Test", value:10);
            myTuple.name = "New Test";*/
            #endregion

            #region Example2
            /*string playerName = "Test Name";
            int value = 50;

            // Tuple : declare type
            //var playerTuple = (playerName, value);
            (string playerName, int value) myPlayerTuple = (playerName, value);

            myPlayerTuple.playerName = "New Player Name";*/
            #endregion

            #region Example3
            var returnedTuple = GetTuple();
            Debug.Log(returnedTuple);

            // Tuple : define a local variable
            //(string playerName, int value) = returnedTuple;
            var (playerName, value) = returnedTuple;
            Debug.Log(playerName);
            #endregion

            #region Example4
            (string playerName, int value) tuple = ("Test Name", 10);
            Debug.Log(tuple.GetType());
            #endregion
        }

        public (string name, int value) GetTuple()
        {
            return ("Test", 10);
        }
    }
}