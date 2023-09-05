namespace IRentNG.Entities.Exceptions
{
    public sealed class PropertyNotFoundException : NotFoundException
    {
        public PropertyNotFoundException(Guid propertyId) : base($"Property with id: {propertyId} doesn't exist in the database.")
        {
        }
    }
}
