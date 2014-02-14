using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateSqlServer.SqlDAL
{
 public interface IGenericReader
    {
         T Load<T>(int id);
         IList<T> Load<T>() where T : class;
         T Load<T>(DateTime dt, string DateTimeFieldName);
    }
}
