using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalBlog.Domain.Entities;

namespace MinimalBlog.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
