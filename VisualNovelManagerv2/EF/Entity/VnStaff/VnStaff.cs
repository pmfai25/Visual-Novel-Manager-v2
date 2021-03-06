﻿using System.ComponentModel.DataAnnotations;

namespace VisualNovelManagerv2.EF.Entity.VnStaff
{
    public class VnStaff: IEntity
    {        
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public string Name { get; set; }
        public string Original { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int? MainAlias { get; set; }
        public virtual VnStaffAliases VnStaffAliases { get; set; }
        public virtual VnStaffLinks VnStaffLinks { get; set; }
    }
}
