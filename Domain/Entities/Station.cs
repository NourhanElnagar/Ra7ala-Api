﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Station : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int CityId { get; set; }
        public int? CompanyId { get; set; } = null;

        // Navigation properties
        public Company? Company { get; set; }
        public City City { get; set; } = null!;
    }
}
