namespace Serilog.Settings.Json.Model
{
    public class Enrich : SerilogSettingArgs
    {
        //todo
        public static explicit operator Enrich(string input)
        {
            return new Enrich { Name = input };
        }
    }
}