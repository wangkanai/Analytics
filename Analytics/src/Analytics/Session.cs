using System;
using System.ComponentModel;

namespace AnalyticsOld
{
    public class Session
    {
		[Description("Anonymously identifies a browser instance. By default, this value is stored as part of the first-party analytics tracking cookie with a two-year expiration.")]
		public string ClientId { get; set; }
	    public Session()
	    {
		    
	    }
    }
}