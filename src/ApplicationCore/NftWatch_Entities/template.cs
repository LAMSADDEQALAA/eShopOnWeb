using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Template
{
    [Key]
    public int TemplateId { get; private set; }
    public string FileName { get; private set; }
    public string FileUrl { get; private set; }
    public string KalartTemplateId { get; private set; }
    //belongs to one watche
    public int WatchId { get; private set; }
    public Watch Watch { get; private set; }
}
