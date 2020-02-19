using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace FodyTest
{
    public partial class PersonDTO: DTOBase
    {
        public string Forename { get; set; }
        public string Surname { get; set; }

        [DoNotNotify]
        public DateTime DateOfBirth { get; set; }

    }
}
