﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace productmanagementsystems.Models
{
    public class TempClientUser
    {

        [Required]
        [DataType(DataType.EmailAddress)]

        public string Mail { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}