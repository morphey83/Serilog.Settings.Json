using System.Collections.Generic;

namespace Serilog.Settings.Json.Model
{
    public class SerilogSetting
    {
        public string Name { get; set; }

        public static explicit operator SerilogSetting(string input)
        {
            return new SerilogSetting {Name = input }; 
        }

        public virtual IEnumerable<KeyValuePair<string, string>> AsKeyValue(string directive, string value = "")
        {
            if (string.IsNullOrEmpty(Name)) return new List<KeyValuePair<string, string>>();
            return new[] { new KeyValuePair<string, string>($"{directive}:{Name}", value) };
        }
    }
}