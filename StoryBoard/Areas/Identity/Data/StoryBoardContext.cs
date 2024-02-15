using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoryBoard.Areas.Identity.Data;
using StoryBoard.Models;

namespace StoryBoard.Data;

public class StoryBoardContext : IdentityDbContext<StoryBoardUser>
{
    public StoryBoardContext(DbContextOptions<StoryBoardContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
