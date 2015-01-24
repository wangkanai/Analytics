using System;
using System.ComponentModel;
using Analytics.Config;

namespace Analytics
{
    public class Tracker
    {		
		[Description("The web property ID for the site being tracked")]
		public string Id { get; set; }
		public ConfigObject ConfigObject { get; set; }

    }
}