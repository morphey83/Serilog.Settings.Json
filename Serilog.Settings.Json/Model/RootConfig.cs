using System.Collections.Generic;
using Newtonsoft.Json;

namespace Serilog.Settings.Json.Model
{
    public class RootConfig: ISerilogConfig
    {
        public SerilogSettings Serilog { get; set; }
        
        public IEnumerable<KeyValuePair<string, string>> GetSettings()
        {
            return Serilog.GetSettings();
        }
    }
}