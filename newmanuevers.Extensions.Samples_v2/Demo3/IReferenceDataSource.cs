﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newmanuevers.Extensions.Samples_v2.Demo3
{
    public interface IReferenceDataSource
    {
         IEnumerable<ReferenceDataItem> GetItems();
    }
}
