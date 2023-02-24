using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Declares namespace to hold extension classes and methods
namespace CustomExtensions
{
    // Organizational purposes - declares a static class
    public static class StringExtensions
    {
        // Adds static method
        public static void FancyDebug(this string str)
        {
            //Prints length whenever fancydebug is executed
            Debug.LogFormat("This string contains {0} characters.", str.Length);
        }
    }
}
