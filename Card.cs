namespace ToDo{
    public class Card{
        private string title;
        private string content;
        private Members member ;
        private string cardName;
        private CardSize size;

        public Card(string title, string content, Members member, string cardName, CardSize size){
            this.title = title;
            this.content = content;
            this.member = member;
            this.cardName = cardName;
            this.size = size;

        }

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public Members Member { get => member; set => member = value; }
        public CardSize Size { get => size; }
        public string CardName { get => cardName; set => cardName = value; }
    }


    public enum CardSize{

        XS = 1,
        S,
        M,
        L,
        XL
    }

    
}

