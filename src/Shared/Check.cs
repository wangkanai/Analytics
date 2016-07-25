using System;
using System.Collections.Generic;
using System.Diagnostics;
using Wangkanai.UniversalAnalytics.Infrastructure;
using Wangkanai.UniversalAnalytics.Internal;

namespace Wangkanai.UniversalAnalytics.Utilities
{
    [DebuggerStepThrough]
    internal static class Check
    {
        public static T NotNull<T>(
            T value, 
            string parameterName)
        {
            if (ReferenceEquals(value, null))
            {
                NotEmpty(parameterName, nameof(parameterName));
                throw new ArgumentNullException(parameterName);
            }
            return value;
        }

        public static string NotEmpty(string value, string parameterName)
        {
            Exception e = null;
            if (ReferenceEquals(value, null))
                e = new ArgumentNullException(parameterName);
            else if(value.Trim().Length == 0)
            e = new ArgumentException(UniversalStrings.ArgumentIsEmpty(parameterName));

            return value;
        }
    }
}