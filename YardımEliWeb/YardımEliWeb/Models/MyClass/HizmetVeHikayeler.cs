using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YardımEliWeb.Models.Entity;

namespace YardımEliWeb.Models.MyClass
{
    public class HizmetVeHikayeler
    {
        public IEnumerable<tblHikayeler> hikayeDeger { get; set; } //hikayeleri tutar.
        public IEnumerable<tblHizmetler> hizmetDeger { get; set; } //hizmetleri tutar.
    }
}