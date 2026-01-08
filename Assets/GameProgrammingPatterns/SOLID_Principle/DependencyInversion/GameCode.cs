using UnityEngine;

namespace Dependency
{
    // Dependency Inversion Principle
    // "Depend upon Abstractions. Do not depend upon concretions."
    // *Concrete class : Simply a class that is fully implemented and can be instantiated using new

    // Bad if want to change to DialogueB it should change the inheritance
    /*public class GameCode : DialogueA { }
    public class DialogueA : MonoBehaviour { }
    public class DialogueB : MonoBehaviour { }*/

    // Good
    public interface IDialogueSystem { }
    public class DialogueA : IDialogueSystem { }
    public class DialogueB : IDialogueSystem { }

    public class GameCode : MonoBehaviour
    {
        private IDialogueSystem dialogue;

        private void Awake()
        {
            // Change only the IDialogueSystem
            dialogue = new DialogueA();
        }
    }
}