using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Models
{
    [Keyless]
    public class Unitary_Heat
    {
        public double EquipmentID {get; set;}
        public string ZoneControl {get; set;}
        public string Heating {get; set;}
        public double EnvironmentalIndex {get; set;}
        [ForeignKey("EquipmentID")]
        public Equipment equipment { get; set; }
        
    }
}