using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Course.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Course.Orm.Configurations {
    public class TodoConfiguration : IEntityTypeConfiguration<Todo> {
        public void Configure(EntityTypeBuilder<Todo> builder) {
            builder.ToTable("Todo");

            builder.HasKey(todo => todo.Id);

            builder.Property(todo => todo.Id).ValueGeneratedOnAdd();
            builder.Property(todo => todo.Title).HasMaxLength(50).IsRequired(true);
        }
    }
}

