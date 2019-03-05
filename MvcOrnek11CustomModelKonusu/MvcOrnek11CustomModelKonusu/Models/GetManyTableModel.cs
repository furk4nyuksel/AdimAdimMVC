using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOrnek11CustomModelKonusu.Models
{
    public class GetManyTableModel
    {
      public List<Categories> Categories{ get; set; }
      public List<Products> Products{ get; set; }
      public List<Shippers> Shippers{ get; set; }
     }

}