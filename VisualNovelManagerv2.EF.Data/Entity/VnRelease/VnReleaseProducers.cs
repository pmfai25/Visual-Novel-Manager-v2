﻿using System.ComponentModel.DataAnnotations;

namespace VisualNovelManagerv2.EF.Data.Entity.VnRelease
{
    public class VnReleaseProducers
    {
        [Key]
        public int PkId { get; set; }
        public int? ReleaseId { get; set; }
        public int? ProducerId { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Name { get; set; }
        public string Original { get; set; }
        public string ProducerType { get; set; }
    }
}
