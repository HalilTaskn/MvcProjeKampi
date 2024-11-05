using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.Repositories;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category> ();

        public List<Category> GetAllBl()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategorName == "" || p.CategorName.Length <= 3 || p.CategorDescription=="" || p.CategorName.Length>= 51)
            {
                //Message hata ; 
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
  