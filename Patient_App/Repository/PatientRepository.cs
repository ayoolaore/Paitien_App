using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;
using Patient_App.Contracts;

namespace Patient_App.Repository
{
    public  class PatientRepository : IRepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(RepositoryContext repositoryContext)
        // : base(repositoryContext)
        {

        }
        public IEnumerable<Patient> GetAllPatients()
        {
            
            return FindAll();
        }

        public Patient GetPatientbById(Guid idPatient)
        {
            return FindByCondition(patient => patient.PatientID.Equals(idPatient))
           .FirstOrDefault();
        }
        public void Create(Patient entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Patient entity)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Patient> FindAll()
        {
            
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> FindByCondition(Expression<Func<Patient, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Patient entity)
        {
            throw new NotImplementedException();
        }
    }
}
