using EmployeesManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManager.Data
{
    public class Skill
    {
        public int Id { get; set; }

        public string Description { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateCreate { get; set; }

        public ICollection<Job> Jobs { get; set; }

        public ICollection<Employee> Employees{ get; set; }


    }
}
