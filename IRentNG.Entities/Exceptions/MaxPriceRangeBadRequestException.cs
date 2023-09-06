namespace IRentNG.Entities.Exceptions
{
    public sealed class MaxPriceRangeBadRequestException : BadRequestException
    {
        public MaxPriceRangeBadRequestException() : base("Max price can't be less than min price.")
        {
        }
    }
}
