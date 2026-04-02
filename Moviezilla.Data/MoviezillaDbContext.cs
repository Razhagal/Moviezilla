using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Moviezilla.Data;

public class MoviezillaDbContext(DbContextOptions<MoviezillaDbContext> options) : IdentityDbContext(options)
{
}