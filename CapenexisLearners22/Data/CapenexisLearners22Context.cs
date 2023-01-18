using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners22;

namespace CapenexisLearners22.Data
{
    public class CapenexisLearners22Context : DbContext
    {
        public CapenexisLearners22Context (DbContextOptions<CapenexisLearners22Context> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearners22.Learner> Learner { get; set; } = default!;

        public DbSet<CapenexisLearners22.Facilitator> Facilitator { get; set; } = default!;

        public DbSet<CapenexisLearners22.Course> Course { get; set; } = default!;
    }
}
