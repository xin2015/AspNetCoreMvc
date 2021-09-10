using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc.Models.System
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string SecurityStamp { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        [Display(Name = "Login Time")]
        public DateTime LoginTime { get; set; }
        public string LoginIP { get; set; }
        public string Remark { get; set; }
        //public string ConcurrencyStamp { get; set; }
        //public DateTime CreationTime { get; set; }
        //public int? CreatorId { get; set; }
        //public DateTime LastModificationTime { get; set; }
        //public int? LastModifierId { get; set; }
    }
}
