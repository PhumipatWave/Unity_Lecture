// #define : use UPPERCASE
// It just symbol either exist or don't exits not hold any data
#define TESTING

using UnityEngine;

public class PreprocessorDirectives : MonoBehaviour
{
    private void Start()
    {
#if TESTING
        Debug.Log("Testing");
#endif

        // If not defind the symbol on top of file it do nothing
        // This process is not include in final build at all
        // Only inclue the true condition to execute
#if TESTING_DONTEXIT
        Debug.Log("Testing can exit");
#elif TESTING2
        Debug.Log("Testing 2 can exit");
#else
        Debug.Log("Testing don't exit");
#endif

#if DEBUG
        Debug.Log("DEBUG");
#elif RELEASE
        Debug.Log("RELEASE");
#endif
    }


}
