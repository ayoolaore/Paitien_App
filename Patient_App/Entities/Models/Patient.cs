using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{

    [Table("patient")]
    public class Patient
    {
        [Key]
        [Column("idPatient")]
        public Guid PatientID { get; set; }

        [Column("First Name")]
        [Required (ErrorMessage = "First name is Required")]
        [StringLength(60, ErrorMessage ="First Name can't be longer than 60 characters")]
        public string First_Name { get; set; }

        [Column("Last Name")]
        [Required(ErrorMessage = "Last name is Required")]
        [StringLength(60, ErrorMessage = "Last Name can't be longer than 60 characters")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = "Date of Birth is Required")]
        public DateTime DateofBirth { get; set; }
    }
}
