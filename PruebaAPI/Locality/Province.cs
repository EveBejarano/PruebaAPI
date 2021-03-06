﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunTourDataLayer.Models
{
    public class Province
    {
        [Key]
        public int Id_Province { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }

        public IEnumerable<City> Cities { get; set; }


    }
}
