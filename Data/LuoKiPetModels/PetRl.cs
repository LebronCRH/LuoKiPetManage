using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetRl
    {
        public int PetRlId { get; set; }
        public string Pname { get; set; }
        public int? Psex { get; set; }
        public string Psalary { get; set; }
        public string Presidence { get; set; }
        public string Pphone { get; set; }
        public string Ptitle { get; set; }
        public string Pcontent { get; set; }
        public int? Pislook { get; set; }
        public int? Pisid { get; set; }
        public int? Pissterilisation { get; set; }
        public int? RlUserId { get; set; }
        public int? ForGetId { get; set; }

        public User RlUser { get; set; }
    }
}
