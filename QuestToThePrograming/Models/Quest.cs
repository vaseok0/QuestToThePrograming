using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestToThePrograming.Models
{
    public class Quest
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Wrong1 { get; set; }
        public string Wrong2 { get; set; }
        public string Wrong3 { get; set; }
        public string Language { get; set; }
        public string TopQuest { get; set; }
        public int NumberQuest { get; set; }
        public string Description { get; set; }
    }
}
