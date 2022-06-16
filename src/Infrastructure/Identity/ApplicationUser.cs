using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;

namespace Microsoft.eShopWeb.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public string WalletId { get;  set; }
    public Language Language { get; set; }
    public Company Company { get; set; }
    public ICollection<Watch> Watch { get; set; }
    public ICollection<NFT> NFT { get; set; }

}
