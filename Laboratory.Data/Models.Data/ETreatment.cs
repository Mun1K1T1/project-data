using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Laboratory_2.Data.Models.Data
{
    public class ETreatment : EEntity
    {
        [ForeignKey("Patient_Key")] 
        public EPatient Patient { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientSecondName { get; set; }
    }
}
