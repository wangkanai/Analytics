using System;
using System.ComponentModel;

namespace AnalyticsOld
{
    /// <summary>
    /// User Timings - Studies have shown that reducing page load time improves the overall user experience of a site. Google Analytics has a number of powerful reports that automatically measure and report on page load times. However, it is also possible to track custom timing information to measure performance information specific to your site. For example to measure the time it takes for a particular JavaScript library to load.
    /// </summary>
    public class Timing : TrackerObject
    {
        [Description("A string for categorizing all user timing variables into logical groups (e.g jQuery).")]
        public string Category { get; private set; }
        [Description("A string to identify the variable being recorded. (e.g. JavaScript Load).")]
        public string Variable { get; private set; }
        [Description("The number of milliseconds in elapsed time to report to Google Analytics. (e.g. 20)")]
        public int Value { get; private set; }
        [Description("A string that can be used to add flexibility in visualizing user timings in the reports. (e.g. Google CDN)")]
        public string Label { get; private set; }

        public Timing(string category, string variable, int value)
        {
            Category = category;
            Variable = variable;
            Value = value;
        }

        public Timing(string category, string variable, int value, string label) : this(category, variable, value)
        {
            Label = label;
        }

        public override string Js()
        {
            var name = GetType().Name.ToLower();
            var js = $"'{name}','{Category}','{Variable}',{Value}";
            if (!string.IsNullOrEmpty(Label)) js += $",'{Label}'";
            return js;
        }
    }
}