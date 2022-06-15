using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Company
{
    [Key]
    public int CompanyId { get; set; }
    public string Name { get; private set; }
    public string Responsible { get; private set; }
    public string Adresse { get; private set; }
    public int Vat { get; private set; }
}
