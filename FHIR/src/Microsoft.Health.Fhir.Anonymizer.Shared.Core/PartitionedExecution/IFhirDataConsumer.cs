﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Health.Fhir.Anonymizer.Core.PartitionedExecution
{
    public interface IFhirDataConsumer<T>
    {
        Task<int> ConsumeAsync(IEnumerable<T> data);

        Task CompleteAsync();
    }
}
