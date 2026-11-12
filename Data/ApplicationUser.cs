using Microsoft.AspNetCore.Identity;
using sharpness_sharp.Data.Models;

namespace sharpness_sharp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public List<Ventas>? lstVentas{get; set;}
}

