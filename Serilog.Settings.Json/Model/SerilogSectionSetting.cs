using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Serilog.Settings.Json.Model
{
    public abstract class SerilogSectionSetting : ISerilogConfig
    {
        [JsonIgnore]
        public abstract string Directive { get; }

        //[JsonProperty("settingsList")]
        public Dictionary<string, string> SettingsList { get; set; }

        public virtual IEnumerable<KeyValuePair<string, string>> GetSettings()
        {
            if(SettingsList == null) return new List<KeyValuePair<string, string>>();

            return string.IsNullOrEmpty(Directive)
                ? SettingsList.AsEnumerable()
                : SettingsList.Select(it => new KeyValuePair<string, string>($"{Directive}:{it.Key}", it.Value));
            
        }
    }
}