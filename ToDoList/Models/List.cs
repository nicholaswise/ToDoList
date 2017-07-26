using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        [Display(Name ="Name Of List")]
        public string ListTitle { get; set; }
        public DateTime ListCreateDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}