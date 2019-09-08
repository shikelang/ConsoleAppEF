using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF.Models
{
    public partial class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.ToTable("Student");
            this.HasKey(p => p.Id);
        }

    }
}
