using System;
using System.Linq;
using ZenTool.Domain.Entity;
using ZenTool.Domain.IRepository;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;

namespace ZenTool.DapperRepository
{
    public abstract class Repository<T> : IRepositoryBase<T> where T:EntityBase
    {
        private readonly string _connectionString= "Database=zentao;Data Source=47.111.184.106;User Id=nalong;Password;Convert Zero Datetime=True;Allow Zero Datetime=True";
        //private readonly string _connectionString= "Database=zentao;Data Source=47.111.184.106;User Id=nalong;Password=kH2%nK0{dT2%bD5;port=3306";
        protected abstract string TableName { get; }
        public long Add(T entity) => throw new NotImplementedException();
        public void Delete(long id) => throw new NotImplementedException();
        public T Get(long id)
        {
            string sql = @$"select * from {TableName} where id={id}";
            using (IDbConnection connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<T>(sql);
            }
        }
        public IQueryable<T> GetList() => throw new NotImplementedException();
        public void Update(T entity) => throw new NotImplementedException();
    }
}
