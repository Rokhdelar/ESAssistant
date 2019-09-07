using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESAssistant.Models
{
    public class Supporter
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name ="姓名")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="联系电话")]
        public int Phone { get; set; }
        [Required]
        [Display(Name ="分公司")]
        public Branch branch { get; set; }
        [Display(Name ="参与过的项目")]
        public ICollection<Project> projects { get; set; }
    }
}
