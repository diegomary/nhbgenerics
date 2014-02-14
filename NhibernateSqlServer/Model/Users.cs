using System;
using System.Text;
using System.Collections.Generic;


namespace NhibernateSqlServer.Model {
    
    public class Users {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual string Userrole { get; set; }
        public virtual string Email { get; set; }
        public virtual string Notes { get; set; }
    }
}
