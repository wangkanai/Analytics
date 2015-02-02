using System.ComponentModel;

namespace Analytics
{
    /// <summary>
    /// Page Tracking - Page tracking allows you to measure the number of views you had of a particular page on your web site. For a web app, you might decide to track a page when a large portion of the screen changes, for example when the user goes from the home screen to the settings screen.
    /// </summary>
    public class Pageview : TrackerObject
	{
		[Description("URL of the page being tracked. By default, analytics.js sets this to the full document URL, excluding the fragment identifier.")]
		public string Location { get; private set; }
		[Description("The page path and query string of the page (e.g. /homepage?id=10). This value must start with a / character.")]
		public string Page { get; private set; }
		[Description("The title of the page (e.g. homepage)")]
		public string Title { get; private set; }

		public Pageview() {}
		public Pageview(string page, string title) : this()
		{
			Page = page;
			Title = title;
		}
		public Pageview(string page, string title, string location) : this(page, title)
		{
			Location = location;
		}
	}
}