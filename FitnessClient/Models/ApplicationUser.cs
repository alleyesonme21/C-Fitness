using Microsoft.AspNetCore.Identity;

namespace FitnessClient.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string FitnessLevel { get; set; }
        public string Gender { get; set; }
    }
}