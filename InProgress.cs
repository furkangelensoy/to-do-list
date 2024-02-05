namespace ToDo{
    public class InProgress : Card
    {

        public static List<InProgress> card = new List<InProgress>();
        public InProgress(string title, string content, Members member) : base(title, content, member, "In Progress", CardSize.XS)
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