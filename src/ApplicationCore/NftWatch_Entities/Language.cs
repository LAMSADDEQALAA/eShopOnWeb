using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Language
{
        [Key]
        public int LanguageId { get; private set; }
        public string lang { get; private set; }


}
