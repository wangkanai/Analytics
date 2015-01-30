using System;
using System.ComponentModel;
using System.Reflection;

namespace Analytics
{
    public class Tracker
    {		
		[Description("The web property ID for the site being tracked")]
		public string Id { get; set; }
		public ConfigObject ConfigObject { get; set; }

		/// <summary>
		/// To send data to Google Analytics, you must create a tracking object. Each tracking object can send data to a single Google Analytics web property.
		/// </summary>
		/// <param name="trackingId">UA-XXXX-Y</param>
		public Tracker(string trackingId)
		{
			Id = trackingId;
		}
		/// <summary>
		/// To send data to Google Analytics, you must create a tracking object. Each tracking object can send data to a single Google Analytics web property.
		/// </summary>
		/// <param name="trackingId">UA-XXXX-Y</param>
		/// <param name="config">All tracking object customization must be done when the object is initially created.</param>
		public Tracker(string trackingId, ConfigObject config) : this(trackingId)
	    {
		    ConfigObject = config;
	    }
    }
}