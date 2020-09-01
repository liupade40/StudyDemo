using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<UserDetail> Detail { get; set; }
    }
    public class UserDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<UserDetail> Detail { get; set; }
    }
    public class UserDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
