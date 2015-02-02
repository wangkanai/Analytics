namespace Analytics.Common
{
	public abstract class FieldOption : Field
	{
		public override string Js()
		{
			var js = base.Js();
			if (string.IsNullOrEmpty(js)) return "";
			return "{" + js + "}";
		}
	}
}