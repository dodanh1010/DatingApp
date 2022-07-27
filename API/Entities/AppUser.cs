using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    //this entities is created to
    //phan biet giua user cua app va non user
    //dung de lam nhieu thu trong database
    public class AppUser
    {
        //prop + tab la khai bao nhanh 1 phuong thuc
        //public la co the get voi set tu moi class khac trong ctrinh
        //protected la co the accessed duoc tu tu class nay va cac class thua ke class nay
        //private thi chi co the goi duoc trong class nay
        public int Id { get; set; } //day la primary key (tu tang)
        public string UserName { get; set; }
        //propfull co the hai cai ben duoi cung 1 luc
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        

    }
}