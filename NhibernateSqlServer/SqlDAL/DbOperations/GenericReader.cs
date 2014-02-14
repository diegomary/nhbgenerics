using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateSqlServer.SqlDAL
{
    public class GenericReader : IGenericReader
    {
         public GenericReader()
         { }       
         public   T Load<T>(int id) 
            {
                ISession session = CoreNhibSqlServer.GetCurrentSession();
                try
                {
                    T us = session.Load<T>(id);
                    return us;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return default(T);
                }
                finally
                {
                    session.Close();
                }
            }
         public IList<T> Load<T>() where T:class
         {
             ISession session = CoreNhibSqlServer.GetCurrentSession();
             try
             {
                 var allusers = session.CreateCriteria<T>().List<T>();
                 return allusers;
             }

             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
                 return null;
             }
             finally
             {
                 session.Close();
             }
         }
         public T Load<T>(DateTime dt, string DateTimeFieldName) 
         {
              ISession session = CoreNhibSqlServer.GetCurrentSession();
              T res = session.CreateCriteria(typeof(T)).Add(Restrictions.Gt(DateTimeFieldName, dt)).UniqueResult<T>();
              return res;
         }
    
    }
}
