namespace IRentNG.Shared.DataTransferObjects
{
    public record ChangePasswordRequestDto
    {
        public string OldPassword { get; init; }
        public string NewPassword { get; init; }
    }
}
