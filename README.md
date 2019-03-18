# Serilog.Settings.Json
Serilog configuration with .json file (framework 4.5+)

Configuration from .json file:

new LoggerConfiguration()
	.ReadFrom.Json("LogSettings.json")
	.CreateLogger();
