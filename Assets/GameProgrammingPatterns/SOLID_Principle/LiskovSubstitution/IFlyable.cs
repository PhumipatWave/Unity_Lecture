using UnityEngine;

namespace Liskov
{
    // Liskov Substitution Principle (LSP)
    // "Subclasses should be substitutable for their base classes"
    // คลาสลูกต้องใช้แทนคลาสแม่ได้ โดยไม่พัง

    // Bad
    /*public class Bird
    {
        public virtual void Fly() 
        {
            Debug.Log("Bird fly");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            Debug.Log("Penguin can't fly");
        }
    }*/

    // Good
    public interface IFlyable
    {
        void Fly();
    }

    public class Eagle : IFlyable
    {
        public void Fly() {}
    }

    public class Penguin
    {
        // Not use IFlyable
    }
}