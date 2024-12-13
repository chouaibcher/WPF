using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class ViewModels
    {
        public string title { get; set; } = "MVVM Example";
        public List<Person> persons { get; set; }
        public ViewModels()
        {
            persons = new List<Person>
            {
                new Person { Id = 1, FirstName = "Chouaib", LastName = "Cher" },
                new Person { Id = 2, FirstName = "Chadane", LastName = "21" },
                new Person { Id = 3, FirstName = "Baki", LastName = "nova" },
                new Person { Id = 4, FirstName = "Sifou", LastName = "18" }


            };
        }

    }
}
