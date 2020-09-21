using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalBlog.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Title")]
        public override string Title { get; set; } = "Info page";

        [Display(Name = "Page content")]
        public override string Text { get; set; } = "Content is filled in by the administrator";
    }
}
