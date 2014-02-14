using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateSqlServer.SqlDAL
{
 public interface IGenericWriter
    {
        T SaveOrUpdate<T>(T t);

    }
}
