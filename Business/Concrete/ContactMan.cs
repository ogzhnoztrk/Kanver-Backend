using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ContactMan : IContactService
    {
        private IContactDal _contactDal;

        public ContactMan(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }


        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(), "Data Getirildi");
        }
    }
}
