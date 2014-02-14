using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;


namespace NhibernateSqlServer
{
    public class CoreNhibSqlServer
    {

        private static ISessionFactory SessionFactory;
        private static void OpenSession()
        {
            Configuration config = new Configuration();
            config.Configure();
            config.AddAssembly(Assembly.GetCallingAssembly());
            SessionFactory = config.BuildSessionFactory();
        }
        public static ISession GetCurrentSession()
        {
            if (SessionFactory == null)
                CoreNhibSqlServer.OpenSession();
            return SessionFactory.OpenSession();
        }              

        public static void CloseSessionFactory()
        {
            if (SessionFactory != null)
                SessionFactory.Close();
        }

    }
}
