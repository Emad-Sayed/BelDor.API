using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastrcture.Service
{
    public interface IService<TSearch,TCreate>
    {
        IResponse Create(TCreate model);
        IResponse GetById(int id);
        IResponse GetAll(TSearch search);
        IResponse Delete(int id);
    }
}
