﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.MVC.LinkedIn.DbLayer.Entities
{
    [Table("Award")]
    public class Award
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Issuer { get; set; }

        [ForeignKey("Experience")]
        public int? ExperienceId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? IssueDate { get; set; }

        public string Description { get; set; }
        
        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
