using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceClassFields.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Announcement = new HashSet<Announcement>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        #region notmappedField

        [NotMapped]
        [Display(Name = "Pan/Pani:")]
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }

        #endregion

        public virtual ICollection<Announcement> Announcement { get; private set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }


    }
}