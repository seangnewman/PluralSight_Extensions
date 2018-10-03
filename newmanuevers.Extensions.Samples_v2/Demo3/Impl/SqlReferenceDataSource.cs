using System.Collections.Generic;

namespace newmanuevers.Extensions.Samples_v2.Demo3.Impl
{

    public abstract class SqlDataSource
    {
        public string Name = "SQL";
    }
    public class SqlReferenceDataSource : SqlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem{ Code="xyz", Description="from Sql"},
                new ReferenceDataItem{ Code="xyz", Description="from Sql 2"}
            };


        }
    }
}
