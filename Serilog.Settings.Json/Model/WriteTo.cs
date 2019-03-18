namespace Serilog.Settings.Json.Model
{
    public class WriteTo: SerilogSettingArgs
    {
        public static explicit operator WriteTo(string input)
        {
            return new WriteTo { Name = input };
        }
    }
}