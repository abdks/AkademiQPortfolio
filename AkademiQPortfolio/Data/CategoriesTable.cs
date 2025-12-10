using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class CategoriesTable
    {
        public CategoriesTable()
        {
            ProjectsTables = new HashSet<ProjectsTable>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<ProjectsTable> ProjectsTables { get; set; }
    }
}
