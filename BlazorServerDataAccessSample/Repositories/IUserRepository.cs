using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerDataAccessSample.Data.Models;

namespace BlazorServerDataAccessSample.Repositories
{
    /// <summary>
    /// マスターメンテ用Repositoryインターフェイス
    /// </summary>
    /// <typeparam name="TEntity">モデルを指定する</typeparam>
    public interface IUserRepository : IMasterRepository<User>
    {

    }
}
