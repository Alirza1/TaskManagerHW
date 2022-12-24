using System;
using System.Diagnostics;

public class ProcessObject
{
    public string ProcessName { get; set; }
    public string MachineName { get; set; }
    public string ProcessId { get; set; }
    public string HandleCount { get; set; }

    public ProcessObject(Process process)
    {
        ProcessName = process.ProcessName;
        MachineName = process.MachineName;
        ProcessId = process.Id.ToString();
        HandleCount = process.HandleCount.ToString();
    }
    public override string ToString()
    {
        return ProcessId + " " + ProcessName + " " + MachineName + " " + HandleCount + " ";
    }
}
