using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Status
{
    [Key]
    public int StatusId { get; private set; }
    public string status { get; private set; }

    //belongs to one watche
    public NFT NFT { get; set; }

}
