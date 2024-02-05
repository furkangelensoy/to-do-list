namespace ToDo{
     public class Done : Card{
        public static List<Done> card = new List<Done>();

        public Done(string title, string content, Members member) : base(title, content, member, "Done", CardSize.S)
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