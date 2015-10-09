using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AnalyticsOld.Common
{
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
}