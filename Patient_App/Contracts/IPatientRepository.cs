using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Patient_App.Contracts
{
   public interface IPatientRepository : IRepositoryBase<Patient>
    {
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatientbById(Guid idPatient);
    }
}

