﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newmanuevers.Extensions.Samples_v2.Demo3
{
    public static class IReferenceDataSourceExtensions
    {
       public static IEnumerable<ReferenceDataItem> GetItemsByCode(this IReferenceDataSource source, string code)
        {
            return source.GetItems().Where(x=> x.Code == code);
        }
    }
}
