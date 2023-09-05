using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRentNG.Shared.DataTransferObjects
{
    public record UserForUpdateDto(string FullName, string ProfilePicture, string Email, string PhoneNumber, string PermanentAddress);
}
