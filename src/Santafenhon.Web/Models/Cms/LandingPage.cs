using Piranha;
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
    [PageType(Title = "Landing page")]
    [ContentTypeRoute(Title = "Default", Route = "/landingpage")]
    public class LandingPage: Page<LandingPage>
    {
        public class OfficialRegion
        {
            public class PositionItem
            {
                public Guid Id { get; set; }
                public string Text { get; set; }

                private static Dictionary<Guid, string> OfficialsList { get; set; }

                static PositionItem()
                {
                    OfficialsList = new Dictionary<Guid, string>
                    {
                        { Guid.Parse("2445EC4A-7544-48AD-B566-F6AC9F71224E"), "Punong Barangay" },
                        { Guid.Parse("FB590AF5-6DD0-45AE-BDC4-CE7D85350D7D"), "Sangguniang Barangay Member" },
                        { Guid.Parse("5F8834BE-89D6-431E-9961-2CB1F65D78EA"), "SK Chairperson" },
                        { Guid.Parse("07BEAD7F-D027-4260-B9E8-B16230E46534"), "Barangay Secretary" }
                    };
                }


                static async Task<PositionItem> GetById(string id, IApi api)
                {
                    var gid = Guid.Parse(id);
                    return new PositionItem
                    {
                        Id = gid,
                        Text = OfficialsList[gid]
                    };
                }

                // Gets all of the available items to choose from using
                // the injected services you specify.
                static async Task<IEnumerable<DataSelectFieldItem>> GetList(IApi api)
                {
                    return OfficialsList.Select(m => new DataSelectFieldItem
                    {
                        Id = m.Key.ToString(),
                        Name = m.Value
                    });
                }
            }

            [Field]
            public StringField Fullname { get; set; }
            [Field]
            public DataSelectField<PositionItem> Position { get; set; }
            [Field]
            public ImageField Picture { get; set; }
            [Field]
            public StringField Facebook { get; set; }
            [Field]
            public StringField Twitter { get; set; }
            [Field]
            public StringField LinkedIn { get; set; }
        }

        [Region]
        public IList<OfficialRegion> Officials { get; set; }
    }
}
