
using Microsoft.EntityFrameworkCore;

namespace Data_Base;

public class ProjectDBContext : DbContext
{
    public ProjectDBContext(DbContextOptions options) : base(options)
    {
    }
}
