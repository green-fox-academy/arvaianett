using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.ViewModels
{
    public class ClassViewModel
    {
        public List<Class> AllClass { get; set; }
        public List<Student> AllStudent { get; set; }
        public Student CurrentStudent { get; set; }
    }
}
