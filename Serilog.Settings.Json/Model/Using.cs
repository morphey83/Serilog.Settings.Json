using System.Collections.Generic;

namespace Serilog.Settings.Json.Model
{
    public class Using : SerilogSetting
    {
        //todo

        public static explicit operator Using(string input)
        {
            return new Using { Name = input };
        }

        public override IEnumerable<KeyValuePair<string, string>> AsKeyValue(string directive, string value = "")
        {
            return base.AsKeyValue(directive, Name);
        }
    }
}