namespace DifferentObjectsInList
{
    using System.Text.Json;

    internal class Program
    {
        static void Main(string[] args)
        {
            var hanger = new HangerSequence
            {
                HangerId = "HG123",
                ProcessSequences = new List<object>
                {
                    new PickAndProcess
                    {
                        Id = 1, RobotProgramId = 20, ProcessConveyor = 2, CurrentDips = 0, RequiredDips = 4
                    },
                    new PickAndProcess
                    {
                        Id = 2, RobotProgramId = 10, ProcessConveyor = 3, CurrentDips = 0, RequiredDips = 1
                    },
                    new ManualOffline
                    {
                        Id = 3, RobotProgramId = 2, ProcessConveyor = 3, ManualOfflineComplete = false
                    },
                    new PickAndProcess
                    {
                        Id = 4, RobotProgramId = 10, ProcessConveyor = 3, CurrentDips = 0, RequiredDips = 2
                    }
                }
            };

            foreach (var sequence in hanger.ProcessSequences)
            {
                switch (sequence)
                {
                    case PickAndProcess pickAndProcess:
                        Console.WriteLine($"PickAndProcess Sequence : {pickAndProcess.Id} {pickAndProcess.RobotProgramId} {pickAndProcess.ProcessConveyor} {pickAndProcess.CurrentDips} {pickAndProcess.RequiredDips}");
                        break;
                    case ManualOffline manualOffline:
                        Console.WriteLine($"ManualOffline Sequence : {manualOffline.Id} {manualOffline.RobotProgramId} {manualOffline.ManualOfflineComplete}");
                        break;
                }
            }

            var jsonString = JsonSerializer.Serialize(hanger);
        }
    }
}