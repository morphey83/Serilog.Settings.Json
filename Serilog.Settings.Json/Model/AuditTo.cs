namespace Serilog.Settings.Json.Model
{
    public class AuditTo : SerilogSettingArgs
    {
        public static explicit operator AuditTo(string input)
        {
            return new AuditTo { Name = input };
        }
    }
}