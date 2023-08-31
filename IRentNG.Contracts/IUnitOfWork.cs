namespace IRentNG.Contracts
{
    public interface IUnitOfWork
    {
        IPropertyRepository Property { get; }
        IUserRepository User { get; }
        Task SaveAsync();
    }
}
