using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Document
{
    [Key]
    public int DocumentId { get; private set; }   
    public string Picture { get; private set; }
    //has one type
    public int DocumentTypeId { get; private set; }
    public DocumentType DocumentType { get; private set; }
    //belongs to a watch
    public Watch Watch { get; private set; }
}
