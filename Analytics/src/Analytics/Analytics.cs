using System;
using System.Runtime.CompilerServices;

namespace Analytics
{
	/// <summary>
	/// This is a singleton service class that will interact with Google Analytics
	/// </summary>
	public sealed class Analytics
    {
		// Singleton
		private static volatile Analytics instance = new Analytics();
		public static Analytics Instance {get { return instance;} }		
        private Analytics() {}
        static Analytics() {}

        // unit testing is not working yet. this my test bed
		public string Render()
		{
            var js = new Send(new Pageview()).Js();
			var tracker = new Tracker("UA-XXXX-Y");
			return tracker.Id; //tracker.Name;
		}	        
    }
}
