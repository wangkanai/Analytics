using System;
using Analytics.Common;

namespace AnalyticsOld
{
	public class Send : IJavascript
	{
		public TrackerObject HitType { get; set; }

        public Send(TrackerObject TrackerObject)
        {
            HitType = TrackerObject;
        }

		public string Js()
		{
			var syntax = HitType.Js();
			var js = $"ga('send', {syntax});";
			return js;
		}
	}
}