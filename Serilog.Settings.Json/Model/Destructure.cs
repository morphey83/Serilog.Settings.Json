namespace Serilog.Settings.Json.Model
{
    public class Destructure : SerilogSettingArgs
    {
        public static explicit operator Destructure(string input)
        {
            return new Destructure { Name = input };
        }
    }
}