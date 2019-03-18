namespace Serilog.Settings.Json.Model
{
    public class Filter : SerilogSettingArgs
    {
        public static explicit operator Filter(string input)
        {
            return new Filter { Name = input };
        }
    }
}