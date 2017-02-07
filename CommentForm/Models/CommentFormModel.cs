using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CommentForm.Models
{
    public class CommentFormModel
    {
        [Key]
        public int ID { get; set; }
        /* same as typing public int ID {
         * get { return this.ID; }
         * set {this.ID = value; }
         * } */

        public string Name { get; set; }
        public string Comment { get; set; }
        public int Priority { get; set; }

    }
}