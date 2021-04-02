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
        public class CategoryRegion
        {
            [Field]
            public StringField Title { get; set; }
            [Field]
            public ImageField Image { get; set; }
            [Field]
            public TextField Body { get; set; }
        }
    }
}
