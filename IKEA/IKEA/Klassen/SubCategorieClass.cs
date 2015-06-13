using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IKEA
{
    public class SubCategorieClass
    {
        public int SubCatID { get; set; }
        public int SubSubCatID { get; set; }
        public string CatName { get; set; }

        public SubCategorieClass(int subCatid, int subSubCatid, string catName)
        {
            this.SubCatID = subCatid;
            this.SubSubCatID = subSubCatid;
            this.CatName = catName;
        }
    }
}