﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Domain
{
    public class Contact
    {   [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
    }
}
