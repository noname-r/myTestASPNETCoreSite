﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myTestASPNETCoreSite.Domain.Entities;

namespace myTestASPNETCoreSite.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
