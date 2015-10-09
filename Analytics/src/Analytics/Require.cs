using Analytics.Common;

namespace AnalyticsOld
{
	public abstract class Require : IJavascript
	{
		public virtual string Js()
		{
			var name = GetType().Name.ToLower();
			var js = $"ga('require', '{name}');";
			return js;
		}
	}
}