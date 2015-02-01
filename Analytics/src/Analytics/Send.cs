using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Analytics
{
	public abstract class Set
	{

	}

	public abstract class Require : IJavascript
	{
		public virtual string Js()
		{
			var name = GetType().Name.ToLower();
			var js = $"ga('require', '{name}');";
			return js;//string.Format("ga('require', '{0}');", name);
		}
	}

	public class Ecommerce : Require
	{
		public override string Js()
		{
			return "ga('require', 'ecommerce', 'ecommerce.js');";
		}
	}

	public class DisplayFeatures : Require
	{

	}

	public abstract class Send
	{
		public string Js(IJavascript method)
		{
			var syntax = method.Js();
			var js = $"ga('send', {syntax});";
			return js;
		}
	}

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

		public string Js()
		{
			var name = GetType().Name.ToLower();
			var options = base.Js()?.Insert(0,",");
			var js = $"'{name}'{options}";
			return options;
		}
	}

	public abstract class Field : IJavascript
	{
		public virtual string Js()
		{
			if (!Properties.Any()) return "";
			var js = "";
			foreach (var property in Properties)
			{
				var name = property.Name;
				var value = Value(property.GetValue(this, null));
				var comma = (!Properties.Last().Equals(property)) ? "," : "";
				js += $"'{name}':{value}{comma}";
			}

			return js;
		}

		protected IEnumerable<PropertyInfo> Properties
		{
			get
			{
				return GetType()
					.GetProperties(BindingFlags.Public | BindingFlags.Instance)
					.Where(x => Exist(x.GetValue(this, null)));
			}
		}
		private string Value(object value)
		{
			if (value is string) return $"'{value.ToString()}'";
			return value.ToString();
		}

		private bool Exist(object value)
		{
			if (value == null) return false;
			if (value as string != null) if (string.IsNullOrEmpty((string)value)) return false;
			if (value as int? == 0) return false;
			if (value as float? == 0.0) return false;
			if (value as bool? == false) return false;
			return true;
		}
	}

	public abstract class FieldOption : Field, IJavascript
	{
		public override string Js()
		{
			var js = base.Js();
			if (string.IsNullOrEmpty(js)) return "";
			return "{" + js + "}";
		}
	}
}