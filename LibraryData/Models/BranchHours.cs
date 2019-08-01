﻿
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public class BranchHours
    {
        public int Id { get; set; }
        public LibraryBranch Branch { get; set; }
        [Range(0,6)]
        public int DayOfWork { get; set; }
        [Range(0, 23)]
        public int OpenTime { get; set; }
        [Range(0, 23)]
        public int CloseTime { get; set; }
    }
}