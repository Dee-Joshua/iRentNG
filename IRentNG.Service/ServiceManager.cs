using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Entities.Models;
using IRentNG.Service.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace IRentNG.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IPropertyService> _propertyService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IUnitOfWork repositoryManager, ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
        {
            _propertyService = new Lazy<IPropertyService>(()
                => new PropertyService(repositoryManager, mapper, logger));
            _userService = new Lazy<IUserService>(()
                => new UserService(repositoryManager, mapper, logger));
            _authenticationService = new Lazy<IAuthenticationService>(()
                => new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public IPropertyService PropertyService => _propertyService.Value;

        public IUserService UserService => _userService.Value;

        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
