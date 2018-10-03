using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newmanuevers.Extensions.Samples_v2.Demo3.Impl
{

    public abstract class XmlDataSource
    {
        public string Name = "XML";
    }
    public class XmlReferenceDataSource : XmlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem{ Code="xyz", Description="from Xml"},
                new ReferenceDataItem{ Code="xyz", Description="from Xml 2"}
            };


        }
    }
}
