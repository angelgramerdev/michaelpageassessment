using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain;


namespace Application.Interfaces
{
    public interface IServiceUser
    {
      Task<ObjResponse> Add(User user);
      Task<ObjResponse> GetUsers();
      Task<ObjResponse> Edit(User user);
      Task<ObjResponse>GetUser(int id);
      Task<ObjResponse> Delete(int id);

    }
}
