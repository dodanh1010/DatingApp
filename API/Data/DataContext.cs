//cai nay la cau noi giua app va database
using API.Entities;
using Microsoft.EntityFrameworkCore; //dong chinh
namespace API.Data //khong nhat thiet phai goi la API.Data
{
    public class DataContext : DbContext //generate constructor
    {
        //constructor
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        //type tv set: appuser class 
        public DbSet<AppUser> Users { get; set; }
    }
}