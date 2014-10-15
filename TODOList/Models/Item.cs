using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TODOList.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string TODOItem { get; set; }
    }
}