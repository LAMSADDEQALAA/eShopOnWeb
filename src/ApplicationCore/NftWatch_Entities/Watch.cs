using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
using System.ComponentModel.DataAnnotations;


namespace Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;
public class Watch
{
    [Key]
    public int WatchId { get; set; }

    public string Marque { get; private set; }


    public string Modèle { get; private set; }


    public string Refernce_number { get; private set; }


    public string Fabrication_Date { get; private set; }


    public string Serial_Number { get; private set; }


    public string State { get; private set; }


    public string With_Paper { get; private set; }


    public string With_Box { get; private set; }


    public string Has_Service { get; private set; }


    public string Movement { get; private set; }


    public string Calibre { get; private set; }


    public string Reserve { get; private set; }


    public string Functions { get; private set; }


    public string Gendre { get; private set; }


    public string Case { get; private set; }


    public string Diametre { get; private set; }


    public string bezel { get; private set; }


    public string Dial { get; private set; }


    public string Glass { get; private set; }


    public string WaterPoof { get; private set; }

    public string Strap_material { get; private set; }

    public string Color { get; private set; }


    public string Buckle { get; private set; }

    public string Buckle_Material { get; private set; }
    //has many pictures
    public List<Picture> Pictures { get; set; }
    //has many documents
    public List<Document> Documents { get; set; }
    // has one template
    public Template Template { get; set; }
    // haas one NFT
    public NFT NFT { get; set; }


}
