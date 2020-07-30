using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApiClassLibrary.Database;
using ApiClassLibrary.Entities;
using ApiClassLibrary.Extensions;
using ApiWebApplication.Data;

namespace ApiWebApplication.Controllers.Api
{
    [Route("api/users/")]
    public class ApiUsersController : BaseApiController<User>
    {
    }
}