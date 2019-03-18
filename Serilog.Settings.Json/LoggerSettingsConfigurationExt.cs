using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Serilog.Configuration;
using Serilog.Settings.Json.Model;

namespace Serilog.Settings.Json
{
    public static class LoggerSettingsConfigurationExt
    {
        public static LoggerConfiguration Json(this LoggerSettingsConfiguration cnf, string path)
        {
            var strSettings = File.ReadAllText(path);
            var settings = JsonConvert.DeserializeObject<RootConfig>(strSettings).GetSettings();
            return cnf.KeyValuePairs(settings);
        }
    }

}
