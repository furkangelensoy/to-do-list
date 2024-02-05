namespace ToDo{

    public class ToDoCard : Card{
        public static List<ToDoCard> card = new List<ToDoCard>();

        public ToDoCard(string title, string content, Members member) : base(title, content, member, "To-Do-List", CardSize.M)
        {
            card.Add(this);
        }

        public static void list(){
            foreach (var item in card){
                Console.WriteLine("Card Name:\t" + item.Title);
                Console.WriteLine("Content:\t" + item.Content);
                Console.WriteLine("Member:\t\t" + item.Member.Name + " " + item.Member.LastName);
                Console.WriteLine("Card Size:\t" + item.Size);
                Console.WriteLine("****************************************");
            }
        }
    }
}