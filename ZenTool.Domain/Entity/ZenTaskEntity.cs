using System;

namespace ZenTool.Domain.Entity
{
    public class ZenTaskEntity:EntityBase
    {
        public string parent { get; set; }
        public string project { get; set; }
        public string module { get; set; }
        public string story { get; set; }
        public string storyVersion { get; set; }
        public string fromBug { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string pri { get; set; }
        public string estimate { get; set; }
        public string consumed { get; set; }
        public string left { get; set; }
        public DateTime deadline { get; set; }
        public string status { get; set; }
        public string subStatus { get; set; }
        public string color { get; set; }
        public string mailto { get; set; }
        public string desc { get; set; }
        public string openedBy { get; set; }
        public string openedDate { get; set; }
        public string assignedTo { get; set; }
        public string assignedDate { get; set; }
        public string estStarted { get; set; }
        public string realStarted { get; set; }
        public string finishedBy { get; set; }
        public string finishedDate { get; set; }
        public string finishedList { get; set; }
        public string canceledBy { get; set; }
        public string canceledDate { get; set; }
        public string closedBy { get; set; }
        public string closedDate { get; set; }
        public string closedReason { get; set; }
        public string lastEditedBy { get; set; }
        public string lastEditedDate { get; set; }
        public string deleted { get; set; }

    }
}
