using IRentNG.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IRentNG.Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Seed data for users
            builder.HasData(
                new User
                {
                    Id = "579CB2F2-5256-4014-8279-08F527B7F302", 
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password123"), // Hashed password for "Password123"
                    FullName = "Josh Admin",
                    ProfilePicture = "https://example.com/user1.jpg",
                    PermanentAddress = "123 Main Street",
                    DateJoined = DateTime.Now
                },
                new User
                {
                    Id = "6A5C9A15-7F19-46FF-9E1D-62D617126006",
                    UserName = "landlord@example.com",
                    NormalizedUserName = "LANDLORD@EXAMPLE.COM",
                    Email = "landlord@example.com",
                    NormalizedEmail = "LANDLORD@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password456"), // Hashed password for "Password456"
                    FullName = "Josh Landlord",
                    ProfilePicture = "https://example.com/user2.jpg",
                    PhoneNumber = "+2349025621988",
                    PermanentAddress = "456 Elm Street",
                    DateJoined = DateTime.Now
                },
                new User
                {
                    Id = "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA",
                    UserName = "landlord1@example.com",
                    Email = "landlord1@example.com",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "YourPasswordHashHere"),
                    FullName = "John Landlord",
                    PhoneNumber = "+1234567890",
                    ProfilePicture = "https://example.com/profile1.jpg",
                    PermanentAddress = "123 Landlord Lane, Lagos",
                    DateJoined = DateTime.Now
                },
                new User
                {
                Id = "826E0C43-871D-4498-B343-8F8260E1127C",
                UserName = "landlord2@example.com",
                Email = "landlord2@example.com",
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "YourPasswordHashHere"),
                FullName = "Jane PropertyOwner",
                PhoneNumber = "+2345678901",
                ProfilePicture = "https://example.com/profile2.jpg",
                PermanentAddress = "456 Landlord Street, Abuja",
                DateJoined = DateTime.Now
                },
                new User
                {
                Id = "91F6AFD4-8D50-40B1-B09E-E799723E952D",
                UserName = "landlord3@example.com",
                Email = "landlord3@example.com",
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "YourPasswordHashHere"),
                FullName = "Chris RealEstate",
                PhoneNumber = "+3456789012",
                ProfilePicture = "https://example.com/profile3.jpg",
                PermanentAddress = "789 Rental Road, Lagos",
                DateJoined = DateTime.Now
                },
                new User
                {
                Id = "3F373D01-67C5-4FBC-92BB-3C84117CAE7B",
                UserName = "landlord4@example.com",
                Email = "landlord4@example.com",
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "YourPasswordHashHere"),
                FullName = "Laura Landlord",
                PhoneNumber = "+4567890123",
                ProfilePicture = "https://example.com/profile4.jpg",
                PermanentAddress = "101 Landlord Avenue, Abuja",
                DateJoined = DateTime.Now
                },
                new User
                {
                Id = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                UserName = "landlord5@example.com",
                Email = "landlord5@example.com",
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "YourPasswordHashHere"),
                FullName = "David Rental",
                PhoneNumber = "+5678901234",
                ProfilePicture = "https://example.com/profile5.jpg",
                PermanentAddress = "234 Property Place, Lagos",
                DateJoined = DateTime.Now
                }
                // Add more users here as needed...
                );
        }
    }
}
