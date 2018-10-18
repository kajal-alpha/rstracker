﻿using HSTrackerModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSTrackerData.Configuration
{
   public class SubUnitConfiguration : EntityTypeConfiguration<SubUnit>
    {
        public SubUnitConfiguration()
        {
            ToTable("SubUnit");
            Property(su => su.Name).IsRequired().HasMaxLength(100);
        }
    }
}
