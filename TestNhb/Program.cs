using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NhibernateSqlServer;
using NhibernateSqlServer.Model;
using NhibernateSqlServer.SqlDAL;


namespace TestNhb
{
    class Program
    {
        static void Main(string[] args)
        {           
            //IGenericReader reader = new GenericReader();
            //IList<User> allusers = reader.Load<User>();


            //IList<User> allusers = new List<User>();
            //for (int i = 0; i< 100; i++)
            //{
            //    allusers.Add(new User { Username = "ToDo",Userrole="user", Email="Noemail", Notes="Notes basic", Password="Mypass"});
            //}
            //IGenericWriter gw = new GenericWriter();


            //foreach (var vr in allusers)
            //{
            //    vr.Password = "123456789";
            //    gw.SaveOrUpdate<User>(vr);

            //}

          


            //User op = usrr.Load<User>(105);
            //op.Email = "xxxxxxxxxxxxxxxxxxx";
            //IList<Topics> alpha = usrr.Load<Topics>();
            //foreach(var v in alpha)
            //{
            //    v.Note = "This is the update";
            //}

            //IGenericWriter gw = new GenericWriter();


            //foreach (var vr in allusers)
            //{
            //    vr.Password = "123456789";
            //    gw.SaveOrUpdate<User>(vr);

            //}

            //UserReader usrr = new UserReader();
            //User u = usrr.Load(107);
            //IList<User> allusers = usrr.Load();




            //string username = "Diego";
            //string pass = "password";
            //ISession session = CoreNhibSqlServer.GetCurrentSession();
            //var allusers = session.CreateCriteria<User>().List<User>();
            //for (int i = 0; i< 100; i++)
            //{
            //    allusers.Add(new User { Username = "ToDo",Userrole="user", Email="Noemail", Notes="Notes basic", Password="Mypass"});
            //}

            //////INSERT NEW DATA
            //using (var transaction = session.BeginTransaction())
            //{
            //    foreach( var usr in allusers)
            //    {
            //        session.Save(usr);
            //    }
            //    transaction.Commit();              
            //}



            //session.Save(allusers);
            //session.Flush();
            //session.Close();



            //IQuery query = session.CreateQuery("FROM Users WHERE username = :name  AND password = :pass  ");
            //query.SetString("name", username);
            //query.SetString("pass", pass);
            //IList<User> acc = query.List<User>();

            //////UPDATE EXISTING DATA
            //acc[0].Email = "zampone@pippopalla.com";
            //acc[0].Notes = "These are new notes after an update";
            //session.Flush();
            //session.Close();

            ////INSERT NEW DATA
            //using (var transaction = session.BeginTransaction())
            //{
            //    User newuser = new User();
            //    newuser.UserName = "DiegoTheMagician";
            //    newuser.Password = "Thisisnewpassword";
            //    newuser.Date = DateTime.Now;
            //    session.Save(newuser);
            //    transaction.Commit();
            //}
            //Console.WriteLine(acc[0].Password);

            //// USe Criteria to get Data  Greater Than
            //IList<User> mylist = session.CreateCriteria(typeof(User))
            //                    .Add(Restrictions.Gt("UserID", 2))
            //                    .List<User>();

            //// USe Criteria to get Data  Greater Than
            //User usr = session.CreateCriteria(typeof(User))
            //                     .Add(Restrictions.Gt("UserID", 2))
            //                     .SetFirstResult(4).
            //                     SetMaxResults(1).UniqueResult<User>();




            //DateTime dt = DateTime.Now.AddMinutes(-150); //dtnow.Subtract(ts);



            //User ust = session.CreateCriteria(typeof(User))
            //    .Add(Restrictions.Eq("UserName", "Diego"))
            //              .Add(Restrictions.Gt("Date", dt))
            //               .SetFirstResult(0).
            //                SetMaxResults(1).
            //                UniqueResult<User>();



            //session.Close();
            //Console.ReadLine();











        }
    }
}
