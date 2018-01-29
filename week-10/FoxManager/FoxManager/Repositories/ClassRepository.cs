using FoxManager.Entities;
using FoxManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class ClassRepository
    {
        private FoxContext foxContext;

        public ClassRepository(FoxContext foxContext)
        {
            this.foxContext = foxContext;
        }

        public List<Class> GetAllClass()
        {
            foxContext.Students.Load();
            return foxContext.Classes.ToList();
        }

        public void AddClass(string name, Class foxClass)
        {
            foxContext.Classes.Add(foxClass);
            foxContext.SaveChanges();
        }

        public void DeleteClass(string name, long id)
        {
            foxContext.Classes.Remove(GetClass(id));
            foxContext.SaveChanges();
        }

        public Class GetClass(long id)
        {
            return foxContext.Classes.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateClass(string name, Class foxClass)
        {
            foxContext.Classes.Update(foxClass);
            foxContext.SaveChanges();
        }
    }
}
