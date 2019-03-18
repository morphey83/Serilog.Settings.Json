using System.Collections.Generic;
using System.Linq;

namespace Serilog.Settings.Json.Model
{
    public class SerilogSettingArgs : SerilogSetting
    {
        public Dictionary<string, string> Args { get; set; }

        public override IEnumerable<KeyValuePair<string, string>> AsKeyValue(string directive, string value = "")
        {
            if(Args == null || !Args.Any())
                return base.AsKeyValue(directive, value);

            return Args
                .Select(it => new KeyValuePair<string, string>($"{directive}:{Name}.{it.Key}", it.Value));

        }

        public static explicit operator SerilogSettingArgs(string input)
        {
            return new SerilogSettingArgs { Name = input };
        }
    }
}