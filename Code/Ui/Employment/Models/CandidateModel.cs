using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace EohTest.Ui.Employment.Models
{
    public class CandidateModel
    {
        public CandidateModel()
        {
            GetCandidates();
        }
        private IEnumerable<Dto.Person> _candidates = new List<Dto.Person>();

        public IEnumerable<Dto.Person> Candidates
        {
            get
            {
                return _candidates;
            }
        }

        internal void GetCandidates()
        {
            _candidates =  Json.Decode<IEnumerable<Dto.Person>>(new EohTest.Service.Crud.Controllers.PersonController().GetPeople());
        }

        internal void DeleteCandidate(int id)
        {
            new Service.Crud.Controllers.PersonController().DeletePerson(id);
        }
    }
}