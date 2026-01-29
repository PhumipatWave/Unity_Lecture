using System;
using UnityEngine;

namespace Delegates
{
    public class Delegates : MonoBehaviour
    {
        // delegate : need to defind defind to variable before use it
        private delegate void AttackDelegate();
        private AttackDelegate attackDelegate;

        private delegate int MyDelegate(string str);

        // Action : can defind and it already use it
        private Action myAction;
        private Action<int> myAction2;
        // Func : like an Action but it dependent to Method type
        private Func<int> myFunc;

        private void Start()
        {
            // delegate : can assign multiple method in once with +
            attackDelegate = MeleeAttack;
            attackDelegate += RangeAttack;
            // call the delegate
            attackDelegate();
            attackDelegate -= RangeAttack;
            attackDelegate();

            myAction = MeleeAttack;
            myAction2 = MyTestFunction2;

            myFunc = MyTestIntFunction;

            MyDelegate myDelegate = MyTestFunction;

            // Lamda expression : use to defind an anonymous method
            Action<int> myTestAction = (int i) => {
                Debug.Log("Test Lamda");
            };

            Func<int, bool> myTestAction2 = (int i) => {
                return false;
            };
        }

        private void MeleeAttack()
        {
            Debug.Log("Melee Attack");
        }

        private void RangeAttack()
        {
            Debug.Log("Range Attack");
        }

        private int MyTestFunction(string myString)
        {
            return 0;
        }

        private void MyTestFunction2(int obj)
        {
            
        }

        private int MyTestIntFunction()
        {
            return 0;
        }
    }
}