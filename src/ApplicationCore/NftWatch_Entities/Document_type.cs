using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Document_type
{
    [Key]
    public int Document_typeId { get; private set; }
    public string Type { get; private set; }
      //belongs to a document  
    public Document Document { get; set; }
}
