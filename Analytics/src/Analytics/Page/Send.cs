using System;
using System.ComponentModel;

namespace Analytics.Page
{
	public class Send
	{
		[Description("URL of the page being tracked. By default, analytics.js sets this to the full document URL, excluding the fragment identifier.")]
		public string Location { get; private set; }
		[Description("The page path and query string of the page (e.g. /homepage?id=10). This value must start with a / character.")]
		public string Page { get; private set; }
		[Description("The title of the page (e.g. homepage)")]
		public string Title { get; private set; }

	    public Send()
	    {
		    
	    }
    }
}