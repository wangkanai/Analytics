using System.ComponentModel;
using System.Runtime.InteropServices;
using Xunit;

namespace Analytics
{
	public class Pageview : FieldOption, IJavascript
	{
		[Description("URL of the page being tracked. By default, analytics.js sets this to the full document URL, excluding the fragment identifier.")]
		public string Location { get; private set; }
		[Description("The page path and query string of the page (e.g. /homepage?id=10). This value must start with a / character.")]
		public string Page { get; private set; }
		[Description("The title of the page (e.g. homepage)")]
		public string Title { get; private set; }

		public Pageview()
		{

		}
		public Pageview(string page, string title) : this()
		{
			Page = page;
			Title = title;
		}

		public Pageview(string page, string title, string location) : this(page, title)
		{
			Location = location;
		}

		public override string Js()
		{
			var name = GetType().Name.ToLower();
			var options = base.Js()?.Insert(0,",");
			var js = $"'{name}'{options}";
			return options;
		}
	}

	public class PageviewTests
	{
		[Fact]
		public void CreatePageviewTest() {
			var js = "ga('send', 'pageview');";
			var pageview = new Pageview();
			Assert.Equal(js, pageview.Js());
		}
	}
}