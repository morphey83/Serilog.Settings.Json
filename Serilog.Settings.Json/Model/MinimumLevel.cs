using System.Collections.Generic;
using System.Linq;

namespace Serilog.Settings.Json.Model
{
    public class MinimumLevel : SerilogSetting
    {
        public string Default { get; set; }
        public Dictionary<string,string> Override { get; set; }

        public override IEnumerable<KeyValuePair<string, string>> AsKeyValue(string directive, string value = "")
        {
            if (string.IsNullOrEmpty(Default)) Default = Name;
            
            var result = new[] {new KeyValuePair<string, string>(directive, Default) }.AsEnumerable();
            
            if (Override != null)
            {
                result = result.Concat(Override.Select(it =>
                    new KeyValuePair<string, string>($"{directive}:override:{it.Key}", it.Value)));
            }

            return result;
        }

        public static explicit operator MinimumLevel(string input)
        {
            return new MinimumLevel { Name = input, Default = input };
        }
    }
}