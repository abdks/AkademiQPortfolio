using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class ProjectsTable
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public int? CategoryId { get; set; }

        public virtual CategoriesTable? Category { get; set; }
    }
}
