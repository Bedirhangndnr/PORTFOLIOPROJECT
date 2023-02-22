using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterUser:IdentityUser<int> //<int>= key değeri
    {
        //User Tablosunda olan fakat aspnetuser tablosunda yer almayan değerler.
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
    }
}
