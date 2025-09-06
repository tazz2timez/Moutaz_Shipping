using Domains.Models;
using Microsoft.AspNetCore.Identity;


namespace DataAccessLibraray.UserModels
{
    public class ApplicationUser : IdentityUser<Guid> {


        public virtual ICollection<TbUserSender> TbSenders { get; set; }
        public virtual ICollection<TbUserReceiver> TbReceivers { get; set; }
        public virtual ICollection<TbUserSubscription> TbUserSubscriptions { get; set; }
        public virtual ICollection<TbShippment>TbShippments { get; set; }


    }
}
