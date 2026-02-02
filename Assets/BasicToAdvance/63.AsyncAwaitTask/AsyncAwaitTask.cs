using System.Threading.Tasks;
using UnityEngine;

namespace AsyncAwaitTask
{
    // Asynchronous programming, run logic without blocking the main thread
    // non linear programming
    // all the code just runs in one thread not multiple threads
    public class AsyncAwaitTask : MonoBehaviour
    {
        public Task task;

        #region Example1
        /*private void Start()
        {
            task = ContactWebServer();
        }

        private void Update()
        {
            if (task.IsCompleted)
            {
                int dataLenght = severReturnData.Length;
                Debug.Log(dataLenght);
            }
        }*/
        #endregion

        #region Example2
        private async void Start()
        {
            string severReturnData = await ContactWebServer();
            Debug.Log(severReturnData);
        }
        #endregion

        public async Task<string> ContactWebServer()
        {
            Debug.Log("Contacting server...");
            // Task : represents an asynchronous operation
            // await : wait until the task is done
            await Task.Delay(3000);
            Debug.Log("Got response");
            return "Data";
        }

        #region Example3
        /*private async void Start()
        {
            Task eggsTask = CookEggs();
            Task baconTask = CookBacon();
            Task toastTask = MakeToast();

            await Task.WhenAll(eggsTask, baconTask, toastTask);

            Debug.Log("Breakfast is ready!");
        }*/

        public async Task CookEggs()
        {
            Debug.Log("Cooking eggs...");
            await Task.Delay(3000);
            Debug.Log("Eggs done");
        }

        public async Task CookBacon()
        {
            Debug.Log("Cooking bacon...");
            await Task.Delay(4000);
            Debug.Log("Bacon done");
        }

        public async Task MakeToast()
        {
            Debug.Log("Making toast...");
            await Task.Delay(1000);
            Debug.Log("Toast done");
        }
        #endregion
    }
}