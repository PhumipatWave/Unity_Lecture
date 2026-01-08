using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class CommandInvoker
    {
        private Stack<ICommand> undoStack = new Stack<ICommand>();
        private Stack<ICommand> redoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);

            redoStack.Clear();
        }

        public void UndoCommand()
        {
            if (undoStack.Count == 0) return;

            ICommand command = undoStack.Pop();
            command.Undo();
            redoStack.Push(command);
        }

        public void RedoCommand()
        {
            if (redoStack.Count == 0) return;

            ICommand command = redoStack.Pop();
            command.Execute();
            undoStack.Push(command);
        }
    }
}