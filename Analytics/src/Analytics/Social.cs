using System;
using System.ComponentModel;

namespace Analytics
{
    public class Social : TrackerObject
    {
        [Description("The network on which the action occurs (e.g. Facebook, Twitter)")]
        public string Network { get; private set; }
        [Description("The type of action that happens (e.g. Like, Send, Tweet).")]
        public string Action { get; private set; }
        [Description("Specifies the target of a social interaction. This value is typically a URL but can be any text. (e.g. http://mycoolpage.com)")]
        public string Target { get; private set; }
        public Social(string network, string action, string target)
        {
            Network = network;
            Action = action;
            Target = target;
        }
        public override string Js()
        {
            var name = GetType().Name.ToLower();
            var js = $"'{name}','{Network}','{Action}',{Target}";            
            return js;
        }
    }
}