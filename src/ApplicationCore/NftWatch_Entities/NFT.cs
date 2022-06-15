using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.ComponentModel.DataAnnotations;


namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class NFT
{
    [Key]
    public int NFTId { get; private set; }
    public string kalartID { get; private set; }
    public bool is_minted { get; private set; }
    //has one status
    public int StatusId { get; private set; }
    public Status Status { get; private set; }
    //belongs to one watche
    public int WatchId { get; private set; }
    public Watch Watch { get; private set; }


}
