namespace IRentNG.Service.Contracts
{
    public interface IServiceManager
    {
        IPropertyService PropertyService { get; }
        IUserService UserService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
