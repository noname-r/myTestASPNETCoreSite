using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myTestASPNETCoreSite.Domain.Repositories.Abstract;

namespace myTestASPNETCoreSite.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
