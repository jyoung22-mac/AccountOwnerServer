using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IAccountRepository
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
    }
}