using IRentNG.Contracts;

namespace IRentNG.Repository
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IPropertyRepository> _propertyRepository;
        private readonly Lazy<IUserRepository> _userRepository;

        public UnitOfWork(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _propertyRepository = new Lazy<IPropertyRepository>(() 
                => new PropertyRepository(repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() 
                => new UserRepository(repositoryContext));
        }

        public IPropertyRepository Property => _propertyRepository.Value;
        public IUserRepository User => _userRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
