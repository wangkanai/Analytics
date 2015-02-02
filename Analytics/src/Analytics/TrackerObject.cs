using Analytics.Common;
using System;

namespace Analytics
{
    public abstract class TrackerObject : FieldOption
    {
        public override string Js()
        {
            var name = GetType().Name.ToLower();
            var options = base.Js()?.Insert(0, ",");
            var js = $"'{name}'{options}";
            return options;
        }
    }
}