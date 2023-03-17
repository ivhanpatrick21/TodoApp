using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Models
{
   // [Table("People")]
    public class User
    {
        // entity framework customize the table or column fields
        public int UserId { get; set; }
        //[Column(name:"First_Name", TypeName ="ntext")]
        public string UserName { get; set; }
       
       // [NotMapped]
        public int UserAge { get; set; }
       public List<Todoo> Todoss { get; set; }
        //public User()
        //{
        //}

        public User(int id, string name, int age)
        {
            UserId = id;
            UserName = name;
            UserAge = age;

        }
    }
}
