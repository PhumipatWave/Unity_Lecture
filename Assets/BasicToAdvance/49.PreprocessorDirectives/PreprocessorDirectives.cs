// #define : use UPPERCASE
// It just symbol either exist or don't exits not hold any data
#define TESTING

// Use for disable warning with specific code
//#pragma warning disable 0168

using UnityEngine;

public class PreprocessorDirectives : MonoBehaviour
{
    // #region : use for code folding
    #region TestRegion
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
        #endregion


#if !DEBUG
#warning This is warning not in debug mode
#error This is error not in debug mode
#endif

        // Can use pragma to disable specific warning
#pragma warning disable
        int i;
#pragma warning restore
        int j;
    }
}
