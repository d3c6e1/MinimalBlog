using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalBlog.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill in the name of the service")]
        [Display(Name = "Service name")]
        public override string Title { get; set; }

        [Display(Name = "Brief description of the service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of the service")]
        public override string Text { get; set; }
    }
}
