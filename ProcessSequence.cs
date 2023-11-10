namespace DifferentObjectsInList
{

    public class HangerSequence
    {
        public string HangerId { get; set; }

        public List<ProcessSequence> ProcessSequences { get; set; }

    }

    public class ProcessSequence
    {
        public int Id { get; set; }

        public int RobotProgramId { get; set; }

        public int ProcessConveyor { get; set; }
    }

    public class PickAndProcess: ProcessSequence
    {
        public int RequiredDips { get; set; }

        public int CurrentDips { get; set; }
    }

    public class ManualOffline : ProcessSequence
    {
        public bool ManualOfflineComplete { get; set; }
    }
}
