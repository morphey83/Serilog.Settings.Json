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
## SerilogSettings.json

```javascript
{
  "Serilog": {
    "Using": [
      "Serilog.Sinks.Console",
      "Serilog.Sinks.File"
    ],
    "MinimumLevel": "Debug",
    "WriteTo": [
      { "Name": "Console" },
      { "Name": "File", "Args": { "path": "log.txt" }  }
    ],
    
    //Enrich : []
    //Filter: []
    //AuditTo: []
    //Destructure: []
    //Properties : {}    
  }
}
```
