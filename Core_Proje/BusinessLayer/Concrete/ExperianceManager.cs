using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperianceManager:IExperianceService
    {
        IExperianceDal _experianceDal;

        public ExperianceManager(IExperianceDal experianceDal)
        {
            _experianceDal = experianceDal;
        }

        public void TAdd(Experiance t)
        {
            _experianceDal.Insert(t);
        }

        public void TDelete(Experiance t)
        {
            _experianceDal.Delete(t);
        }

        public Experiance TGetByID(int id)
        {
            return _experianceDal.GetById(id);
        }

        public List<Experiance> TGetList()
        {
            return _experianceDal.GetList();
        }

        public List<Experiance> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experiance t)
        {
            _experianceDal.Update(t);
        }
    }
}
