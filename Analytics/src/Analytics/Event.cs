using System;
using System.ComponentModel;

namespace Analytics
{
	/// <summary>
	/// Event tracking allows you to measure how users interact with the content of your website. For example, you might want to measure how many times a button was pressed, or how many times a particular item was used in a web game.
	/// </summary>
	public class Event : TrackerObject
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

		public override string Js()
		{
            var name = GetType().Name.ToLower();
            var js = $"'{name}','{Category}','{Action}'";
            if (!string.IsNullOrEmpty(Label)) js += $",'{Label}'";
            if (!string.IsNullOrEmpty(Label) && Value > 0) js += $",{Value}";
            return js;
		}
	}
}