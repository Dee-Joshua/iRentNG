using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRentNG.Shared.DataTransferObjects
{
    public record UserDto(string Id, string FullName, string ProfilePicture, string Email, string PhoneNumber);
}
