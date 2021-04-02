using Piranha.AttributeBuilder;
using Piranha.Models;

namespace Santafenhon.Web.Models.Cms
{
    [PostType(Title = "Standard post")]
    public class StandardPost : Post<StandardPost>
    {
    }
}