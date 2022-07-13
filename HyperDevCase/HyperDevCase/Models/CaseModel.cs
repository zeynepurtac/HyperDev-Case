using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using HyperDevCase.Models;


namespace HyperDevCase.Models
{
    public class Company
    {
        public short Companyid { get; set; }
        [Required]
        [Column(TypeName = "nchar(100)")]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyType { get; set; }
        [Required]
        [Column(TypeName = "nchar(100)")]
        public string TaxAdministration { get; set; }
        [Required]
        public long TaxNumber { get; set; }
        [Required]
        [Column(TypeName = "nchar(50)")]
        public string CompanyCity { get; set; }
        [Required]
        [Column(TypeName = "nchar(50)")]
        public string CompanyDistrict { get; set; }
        [Required]
        [Column(TypeName = "nchar(100)")]
        public string CompanyAdress { get; set; }

    }

    public class Department
    {
        [Key]
        public short Departmentid { get; set; }
        [Required]
        [Column(TypeName = "nchar(50)")]
        public string DepartmentName { get; set; }
        [Required]
        public string DepartmentType { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public Company? Company { get; set; }


    }
}
