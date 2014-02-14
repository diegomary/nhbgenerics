using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateSqlServer.SqlDAL
{
    public class GenericWriter : IGenericWriter
    {

        public GenericWriter()
        { }

        public T SaveOrUpdate<T>(T t)
        {
            ISession session = CoreNhibSqlServer.GetCurrentSession();

            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    session.SaveOrUpdate(t);                 
                    transaction.Commit();
                    return t;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                    return default(T);
                }
                finally
                {
                    session.Close();
                }
            }

        }
    }
}
