using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESAssistant.Models
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "分公司名称")]
        public string Name { get; set; }
        [Display(Name ="地址")]
        public string Address { get; set; }
        [Display(Name ="备注")]
        public string Remark { get; set; }
    }
}
