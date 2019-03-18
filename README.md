# Serilog.Settings.Json
Serilog configuration with .json file (framework 4.5+)

## Intalling
```
Install-Package Serilog.Settings.Json
```

## Usage

```c#
new LoggerConfiguration()
	.ReadFrom.Json("SerilogSettings.json")
	.CreateLogger();
```
