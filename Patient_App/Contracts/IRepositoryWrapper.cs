using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_App.Contracts
{
    public interface IRepositoryWrapper
    {
        IPatientRepository Patient { get; }
    }
}
