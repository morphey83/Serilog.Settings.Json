using System.Collections.Generic;

namespace Serilog.Settings.Json.Model
{
    public interface ISerilogConfig
    {
        IEnumerable<KeyValuePair<string, string>> GetSettings();
    }
}
