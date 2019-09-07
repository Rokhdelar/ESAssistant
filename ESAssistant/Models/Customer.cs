using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESAssistant.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string BIZID { get; set; }
        [Required]
        [Display(Name ="客户名称")]
        public string Name { get; set; }
        [Display(Name ="联系人")]
        public string Contact { get; set; }
        [Display(Name="联系电话")]
        public string Phone { get; set; }
        [Display(Name="备注")]
        public string Remark { get; set; }
    }
}
