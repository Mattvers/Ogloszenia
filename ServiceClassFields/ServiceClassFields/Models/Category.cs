using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ServiceClassFields.Models
{
    public class Category
    {
        public Category()
        {
            this.Announcement_Category = new HashSet<Announcement_Category>();
        }

        [Key]
        [Display(Name = "Id kategorii:")]
        public int Id { get; set; }
        
        [Display(Name = "Nazwa kategorii:")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Id rodzica:")]
        [Required]
        public int ParentId { get; set; }

        #region SEO

        [Display(Name = "Tytuł w Google")]
        [MaxLength(72)]
        public string MetaTitle { get; set; }

        [Display(Name = "Słowa kluczowe")]
        [MaxLength(160)]
        public string Keywords { get; set; }

        [Display(Name = "Słowa kluczowe Google")]
        [MaxLength(160)]
        public string MetaDescription { get; set; }

        [Display(Name = "Treść strony")]
        [MaxLength(500)]
        public string Content { get; set; }

        #endregion

        public ICollection<Announcement_Category> Announcement_Category { get; set; }
    }
}