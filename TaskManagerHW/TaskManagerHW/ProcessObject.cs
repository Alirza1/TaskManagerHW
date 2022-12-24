using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerHW
{
    public class ProcessObject
    {
        public string ProcessName { get; set; }
        public string MachineName { get; set; }
        public string ProcessId { get; set; }
        public string HandleCount { get; set; }
        public Process Proccess { get; set; }
        public ProcessObject(Process process)
        {
            Proccess= process;
            ProcessName = process.ProcessName;
            MachineName = process.MachineName;
            ProcessId = process.Id.ToString();
            HandleCount = process.HandleCount.ToString();
        }

        
        public override string ToString()
        {
            return "Id: " + ProcessId + " Name: " + ProcessName + " Machine: " + MachineName + "  Handled: " + HandleCount;
        }
    }
}
