using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Models
{
    [Keyless]
    public class Exhaust_Fan
    {
        public double EquipmentID {get; set;}
        public string DamperControl {get; set;}
        
        [ForeignKey("EquipmentID")]
        public Equipment equipment { get; set; }

        
    }
}