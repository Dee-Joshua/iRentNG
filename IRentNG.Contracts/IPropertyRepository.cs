﻿using IRentNG.Entities.Models;

namespace IRentNG.Contracts
{
    public interface IPropertyRepository
    {
        Task<IEnumerable<Property>> GetPropertiesAsync(string userId, bool trackChanges);

        Task<Property> GetPropertyAsync(string userId, Guid id, bool trackChanges);
    }
}
