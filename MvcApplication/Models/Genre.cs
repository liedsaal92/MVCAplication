﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Genre
    {
        public string Name { get; set; }
        public int genreId { get; set; }
        public string descripcion { get; set; }
        public List<album> Albums { get; set; }
    }
}