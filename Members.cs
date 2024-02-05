using System.Data.Common;

namespace ToDo{
    public class Members{
        private string name;
        private string lastName;
        private int id;

        public Members(string name, string lastName, int id){
            
            this.name = name;
            this.lastName = lastName;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; }
    }

}