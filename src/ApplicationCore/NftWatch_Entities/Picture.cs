using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Picture
{
    [Key]
    public int PictureId { get; private set; }
    public string Path { get; private set; }

    //belongs to one watche
    public int WatchId { get; private set; }
    public Watch Watch { get; private set; }
}
