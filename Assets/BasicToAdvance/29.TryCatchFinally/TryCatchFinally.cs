using System;
using UnityEngine;

namespace TryCatchFinally
{
    public class TryCatchFinally : MonoBehaviour
    {
        private void Start()
        {
            // try : use for try to run the script if error it will continue run to catch
            try
            {
                /*int a = 0;
                int b = 1 / a;*/

                Player player = new Player();
                player.ThrowNameException();

                // This down line will not run if the top line are error
                Debug.Log("Error");
            }

            /*// catch (error_type) : can use to defind the error type to catch it
            catch (DivideByZeroException)
            {
                Debug.Log("DivideByZeroException");
            }

            // catch (Exception) : revice the error type of try code
            // can debug to know what is error type and script line that error
            // catch : can use when to defind condition of exception type
            catch (Exception exception) when (exception is DivideByZeroException)
            {
                Debug.Log($"{exception.Message}, {exception.StackTrace}");
            }*/

            // catch : use to fix a error of the script
            catch (Exception exception)
            {
                Debug.Log($"{exception.Message}, {exception.StackTrace}");

                // throw : use to rethrow the exception
                throw;

                return;
            }

            // finally : alway run in the last of this operation
            // even has a return in catch
            // finally : use to clean a error script
            finally
            {
                Debug.Log("Finally");
            }

            Debug.Log("Pass Eror");
        }

        private class Player
        {
            // You can create owns exception by inheritance class from exception
            public class InvalidPlayerNameException : Exception { }
            public void ThrowNameException()
            {
                throw new InvalidPlayerNameException();
            }

            public void TestFunction()
            {
                // throw : use to spawn an exception for your own exception
                throw new Exception("Player exception");
            }
        }
    }
}