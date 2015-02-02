using System;
using System.Collections;

namespace Analytics
{
	public abstract class Send
	{
		public string Js(IJavascript method)
		{
			var syntax = method.Js();
			var js = $"ga('send', {syntax});";
			return js;
		}
	}
}