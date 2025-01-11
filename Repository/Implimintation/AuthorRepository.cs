using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using WEB._Obj;
using WEB.Config.Interfaces;
using WEB.Repository.Intarfaces;

namespace WEB.Repository.Implimintation
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IHostConfige _hostConfige;

        public AuthorRepository(IHostConfige hostConfige)
        {
            _hostConfige = hostConfige;
        }

        public async Task<Author> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(_hostConfige.ConnectionString))
            {
                const string command = @"SELECT Id,
                                                    CreatedDate,
                                                    Subject,
                                                    IsSpam
                                             FROM [PayOnlineSystem.BayesianFilter].[dbo].[Bayesian] (NOLOCK)
                                             WHERE Subject = @subject";

                
            }
        }


    }
}
