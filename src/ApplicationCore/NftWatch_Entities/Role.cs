using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Role
{

    [Key]
    public int RoleId { get; private set; }
    public string role { get; private set; }
}
