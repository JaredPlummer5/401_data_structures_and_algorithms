using Xunit;
namespace CodeChallenges
{
  public class StackQueuePsuedo
  {

      private Stack enqueueStack;
      private Stack dequeueStack;

      public StackQueuePsuedo()
      {
        enqueueStack = new Stack();
        dequeueStack = new Stack();
      }

      public void Enqueue(int value)
      {
        // All new elements are pushed to the enqueue stack
        enqueueStack.Push(value);
      }

      public int Dequeue()
    {
      // If dequeue stack is empty, transfer elements from enqueue stack to dequeue stack
      if (dequeueStack.IsEmpty())
      {
        while (!enqueueStack.IsEmpty())
        {
          dequeueStack.Push(enqueueStack.Pop());
        }

        // Pop the top element from the dequeue stack (FIFO)
        return dequeueStack.Pop();
      }
      // Pop the top element from the dequeue stack (FIFO)
      return dequeueStack.Pop();
    }




  }
  }

 