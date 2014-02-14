using System;
using System.Text;
using System.Collections.Generic;


namespace NhibernateSqlServer.Model {
    
    public class Topics {
        public virtual int Id { get; set; }
        public virtual string Language { get; set; }
        public virtual int Skill { get; set; }
        public virtual string Note { get; set; }
        public virtual bool Isoutofdate { get; set; }
        public virtual bool Iscuttingedge { get; set; }
        public virtual string Description { get; set; }
        public virtual byte[] Picture { get; set; }
        public virtual string Recruiter { get; set; }
    }
}
