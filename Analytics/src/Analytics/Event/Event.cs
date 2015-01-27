using System;
using System.ComponentModel;

namespace Analytics.Event
{
	/// <summary>
	/// Event tracking allows you to measure how users interact with the content of your website. For example, you might want to measure how many times a button was pressed, or how many times a particular item was used in a web game.
	/// </summary>
	public class Event
	{
		[Description("Typically the object that was interacted with (e.g. button)")]
		public string Category { get; set; }

		[Description("The type of interaction (e.g. click)")]
		public string Action { get; set; }

		[Description("Optional: The type of interaction (e.g. click)")]
		public string Label { get; set; }

		[Description("Optional: Values must be non-negative. Useful to pass counts (e.g. 4 times)")]
		public int Value { get; set; }
		/// <summary>
		/// To send an event, you pass the ga function the send command with the event hit type
		/// </summary>
		/// <param name="category">Typically the object that was interacted with (e.g. button)</param>
		/// <param name="action">The type of interaction (e.g. click)</param>
		public Event(string category, string action)
		{
			Category = category;
			Action = action;
		}

		public Event(string category, string action, string label) : this(category, action)
		{
			Label = label;
		}

		public Event(string category, string action, string label, int value) : this(category, action, label)
		{
			Value = value;
		}

		private string Optional()
		{
			if (Label != null && Value != 0)
				return string.Format(", '{0}', {1}", Label, Value);
			if (Label != null)
				return string.Format(", '{0}'", Label);
			return "";
		}

		public override string ToString()
		{
			var js = string.Format("ga('send', 'event', '{0}', '{1}'{2});",
				Category,
				Action,
				Optional()
				);
			// waiting for visual studio 2015 rtm
			//var gs = $"ga('send', 'event', ' {Category}', '{Action}'{Optional()});";
			return js;
		}
	}
}