using System.Threading;
using UnityEngine;

namespace Multithreading
{
    // Take advantage of all the cores in a CPU to run code insanely fast
    public class Multithreading : MonoBehaviour
    {
        private int resourceAmount;
        private object resourceLock = new object();

        private void Start()
        {
            #region Example1
            /*Thread workerThread = new Thread(new ThreadStart(CalculatePathfinding));
            workerThread.Start();

            Debug.Log("Main thread work...");
            for (int i = 0; i < 10; i++)
            {
                Debug.Log($"Main thread work... {i}");
                // Simulate a heavy task
                Thread.Sleep(500);
            }

            // Wait for the worker thread to finish
            workerThread.Join();

            Debug.Log("Main thread done");*/
            #endregion

            #region Example2
            /*Thread[] threadArray = new Thread[10];
            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i] = new Thread(AddResorce);
            }
            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i].Start();
            }
            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i].Join();
            }
            Debug.Log($"resourceAmount : {resourceAmount}");*/
            #endregion

            #region Example3
            //DeadlockExample();
            #endregion

            #region Example4
            for (int i = 0; i < 10; i++)
            {
                // ThreadPool : manage a pool of worker threads, reducing the overhead of creating and destroying threads
                ThreadPool.QueueUserWorkItem(DoWork);
            }
            #endregion
        }

        private void CalculatePathfinding()
        {
            Debug.Log("Calculating pathfinding...");

            for (int i = 0; i < 10; i++)
            {
                Debug.Log($"Calculating pathfinding... {i}");
                // Simulate a heavy task
                Thread.Sleep(600);
            }
            Debug.Log("Pathfinding done");
        }

        private void AddResorce()
        {
            for (int i = 0; i < 10000; i++)
            {
                // lock : execute all code in all threads one by one
                lock (resourceLock)
                {
                    int tmpResourceAmount = resourceAmount;
                    tmpResourceAmount++;
                    resourceAmount = tmpResourceAmount;
                }
            }
        }

        private void DoWork(object obj)
        {
            Debug.Log($"{Thread.CurrentThread.ManagedThreadId} started");
            Thread.Sleep(500);
            Debug.Log($"{Thread.CurrentThread.ManagedThreadId} finish");
        }

        // Example of a deadlock situation
        // the program get frozen because two threads are waiting for each other to release locks
        private void DeadlockExample()
        {
            object lockA = new object();
            object lockB = new object();

            Thread thread1 = new Thread(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(100); // Simulate some work
                    lock (lockB)
                    {
                        Debug.Log("Thread 1 acquired both locks");
                    }
                }
            });

            Thread thread2 = new Thread(() =>
            {
                lock (lockB)
                {
                    Thread.Sleep(100); // Simulate some work
                    lock (lockA)
                    {
                        Debug.Log("Thread 2 acquired both locks");
                    }
                }
            });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }
    }
}