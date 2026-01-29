using UnityEngine;

namespace Generics
{
    public class Generics : MonoBehaviour
    {
        #region Example1
        private void Start()
        {
            // <> : it call Generic
            //List<>

            MyList<int> myIntList = new MyList<int>();
            myIntList.field = 5;

            MyList<bool> myBoolList = new MyList<bool>();
            myBoolList.field = true;
            Debug.Log(myBoolList.MyFunction());

            TestFunction(5);
        }

        // Generic : usaully name with T
        // use to defind any type in this class to use
        private class MyList<T>
        {
            public T field;

            public T MyFunction()
            {
                // Generic Type : Can't return null
                //return null;

                // Use default to return defualt value of this type
                return default;
            }
        }

        // Generic : can use where to check is value type is the target
        private class TClass<T> where T : class { }

        // Can defind multiple generic
        private class MyTest<T1, T2, T3>
        {
            public T1 field1;
            public T2 field2;
            public T3 field3;
        }

        // Generic Function
        private void TestFunction<T>(T p)
        {
            Debug.Log(p);
        }

        // Generic Struct
        private struct TestStruct<T>
        {
            public T structT;
        }

        // Generic Interface
        private interface TestInterface<T>
        {
            public T MyFunction();
        }
        #endregion

        #region Example2
        /*private void Start()
        {
            MyList<Player> myIntList = new MyList<Player>();
            myIntList.field = new Player();
            Debug.Log(myIntList.MyFunction());
        }

        private class Player { }

        // new() : it like Constructor
        private class MyList<T> where T : class, new()
        {
            public T field;

            public T MyFunction()
            {
                return new T();
            }
        }*/
        #endregion

        #region Example3
        public interface IAttackable 
        {
            public int GetAttackPoints();
        }

        public interface IDefendable
        {
            public int GetDefendPoints();
        }

        // Generic Type : Defend the error of normal use of code
        private void GetAttackWinner<TAttackable, TDefendable>(TAttackable attackable, TDefendable defendable) where TAttackable : IAttackable where TDefendable : IDefendable
        {
            attackable.GetAttackPoints();
            defendable.GetDefendPoints();
        }

        // But this not defend the error
        /*private void CollectItem()
        {
            Inventory<Gold> goldInventory = new Inventory<Gold>();
            Inventory<Silver> silverInventory = new Inventory<Silver>();

            goldInventory.Add(new Silver);
        }

        private class Gold { }
        private class Silver { }

        private class Inventory<T> 
        {
            public void Add(T t) { }
        }*/
        #endregion
    }
}