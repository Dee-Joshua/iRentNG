﻿using IRentNG.Contracts;
using IRentNG.Entities.Models;

namespace IRentNG.Repository
{
    internal sealed class PropertyRepository : RepositoryBase<Property>, IPropertyRepository
    {
        public PropertyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
