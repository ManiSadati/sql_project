using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class player:employee
    {
        public int Ngame { set; get; }
        public int Ngoal { set; get; }
        public string HP { set; get; }
        public int val { set; get; }
        public player(int id, int cid, string Ctype, string firstName, string lastname, string email, string pass, string phone, int worktime, int payment,int Ngame,int Ngoal,string HP,int val):base(id,cid,Ctype,firstName,lastname,email,pass,phone,worktime,payment)
        {
            this.Ngame = Ngame;
            this.Ngoal = Ngoal;
            this.HP = HP;
            this.val = val;
        }
        public player()
        {
            this.firstname = "";
            this.lastname = "";
            this.email = "";
            this.ID = 0;
            this.CID = 0;
            this.Ctype = "";
            this.pass = "";
            this.worktime = 0;
            this.payment = 0;
            this.phone = "";
            this.Ngame = 0;
            this.Ngoal = 0;
            this.HP = "";
            this.val = 0;
        }
    }
}
