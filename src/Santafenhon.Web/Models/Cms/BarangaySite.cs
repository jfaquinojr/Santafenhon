using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santafenhon.Web.Models.Cms
{
    [SiteType(Title = "Barangay Website")]
    public class BarangaySite : SiteContent<BarangaySite>
    {

        public class BarangayProfileRegion
        {
            [Field(Title = "Punong Barangay")]
            public StringField BarangayCaptain { get; set; }

            [Field(Title = "Sangguniang Barangay Member 1")]
            public StringField SanggunianBarangayMember1 { get; set; }

            [Field(Title = "Sangguniang Barangay Member 2")]
            public StringField SanggunianBarangayMember2 { get; set; }

            [Field(Title = "Sangguniang Barangay Member 3")]
            public StringField SanggunianBarangayMember3 { get; set; }

            [Field(Title = "Sangguniang Barangay Member 4")]
            public StringField SanggunianBarangayMember4 { get; set; }

            [Field(Title = "Sangguniang Barangay Member 5")]
            public StringField SanggunianBarangayMember5 { get; set; }

            [Field(Title = "Sangguniang Barangay Member 6")]
            public StringField SanggunianBarangayMember6 { get; set; }

            [Field(Title = "Sangguniang Barangay Member 7")]
            public StringField SanggunianBarangayMember7 { get; set; }

            [Field(Title = "SK Chairperson")]
            public StringField SkChairperson { get; set; }

            [Field(Title = "Barangay Secretary")]
            public StringField BarangaySecretary { get; set; }
        }


        [Region(Title = "Barangay Profile")]
        public BarangayProfileRegion Profile { get; set; }
    }
}
