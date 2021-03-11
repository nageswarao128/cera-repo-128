﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CERA.Entities.Models
{
    [Table("tbl_Resources")]
    public class CeraResources
    {   
        [Key]
        public int? ResourceID { get; set; } 
        public string Name { get; set; }
        public string RegionName { get; set; }
        public string ResourceGroupName { get; set; }
        public string ResourceType { get; set; }
    }
}
