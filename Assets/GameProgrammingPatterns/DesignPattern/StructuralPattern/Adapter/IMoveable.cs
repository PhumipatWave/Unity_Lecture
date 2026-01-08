using UnityEngine;

namespace Adapter
{
    // Target : The Interface your code expect
    public interface IMoveable
    {
        void Move(string moveAction);
    }
}