using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;


namespace DataAccessLayer.Abstract
{
    public class EfContactDal:GenericRepository<Contact>, IContactDal

    {
    }
}
