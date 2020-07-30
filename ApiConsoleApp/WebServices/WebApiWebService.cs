using ApiClassLibrary.Entities;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsoleApp.WebServices
{
    public interface WebApiWebService
    {
        [Get("/api/users/")]
        Task<List<User>> Users();

        [Get("/api/users")]
        Task<List<User>> Users(string subItem);
    }
}
