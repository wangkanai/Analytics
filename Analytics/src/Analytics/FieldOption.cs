namespace Analytics
{
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