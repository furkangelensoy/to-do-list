using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace ToDo{
    public class Board{
        static Dictionary<int,Members> member = DefaultMembers.DefaultTeamMembers();

        public void run(){
            Card x = new ToDoCard("Math-101","Physic math 101",member[1]);
            Card y = new InProgress("Physic-101","Study Physic 101",member[2]);
            Card z = new Done("Chemistry-101","Study Chemistry 101",member[3]);

            bool r = true;
            while(r){
                Console.WriteLine("Please select the action you want to perform: \n" + "1- Add Card\n" + 
                "2- Delete Card\n" + "3- Update Card\n" + "4- Move the Card\n" + "5- List Board\n" + "6- List Members\n" + "7- Exit");
                int select = int.Parse(Console.ReadLine());
                switch(select){
                    case 1:
                        addCard();
                        break;
                    case 2:
                        deleteCard();
                        break;
                    case 3:
                        UpdateCard();
                        break;
                    case 4:
                        MoveCard();
                        break;
                    case 5:
                        ListBoard();
                        break;
                    case 6:
                        ListMembers();
                        break;
                    case 7:
                        r = false;
                        break;
                    default:
                        break;
                }


            }
        }

        public void addCard(){
            Console.Write("Please enter card title: ");
            string title = Console.ReadLine();
            Console.Write("Please enter the content: ");
            string content = Console.ReadLine();
            ListMembers();
            Console.WriteLine("Please select a member id: ");
            int id = int.Parse(Console.ReadLine());
            while(!member.Keys.Contains(id)){
                Console.WriteLine("Please enter a valid id: ");
                id = int.Parse(Console.ReadLine());
            }
            Members selectedMember = member[id];
            Console.WriteLine("Please select your card's line\n" + "1- ToDo\n" + "2- InProgress\n" + "3- Done");
            int select = int.Parse(Console.ReadLine());

            switch(select){
                case 1:
                    Card newCardToDo = new ToDoCard(title,content,selectedMember);
                    Console.WriteLine("Your card has been succesfully added to ToDo Line");
                    break;
                case 2:
                    Card newCardInProgress = new InProgress(title,content,selectedMember);
                    Console.WriteLine("Your card has been succesfully added to InProgress Line");
                    break;
                case 3:
                    Card newCardDone = new Done(title,content,selectedMember);
                    Console.WriteLine("Your card has been succesfully added to Done Line");
                    break;
                default:
                    break;
            }
        
       }

        public void deleteCard(){
            Console.WriteLine("Please select your card's line \n1- ToDo\n 2- InProgress\n 3- Done");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the card name: ");
            string name = Console.ReadLine();

            switch(select){
                case 1:
                    for(int i = 0; i < ToDoCard.card.Count; i++){
                        if(ToDoCard.card[i].Title == name){
                            ToDoCard.card.Remove(ToDoCard.card[i]);
                        }
                    }
                    break;
                case 2:
                    for(int i = 0; i < InProgress.card.Count; i++){
                        if(InProgress.card[i].Title == name){
                            InProgress.card.Remove(InProgress.card[i]);
                        }
                    }
                    break;
                case 3:
                    for(int i = 0; i < Done.card.Count; i++){
                        if(Done.card[i].Title == name){
                            Done.card.Remove(Done.card[i]);
                        }
                    }
                    break;
                default:
                    break;
            }

       }

       public void UpdateCard(){

            Console.WriteLine("Please enter the card's title: ");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Please enter the card's content: ");
            string newContent = Console.ReadLine();
            ListMembers();
            Console.WriteLine("Please select a member id");
            int newId = int.Parse(Console.ReadLine());
            while(!member.Keys.Contains(newId)){
                Console.WriteLine("Please enter a valid id");
                newId = int.Parse(Console.ReadLine());
            }
            Members newSelectedMember = member[newId];
            Console.WriteLine("Please select the old card's line \n 1- Todo\n 2- InProgress\n 3-Done");
            int select = int.Parse(Console.ReadLine());

            switch(select){
                case 1:
                    Console.WriteLine("Please enter the old title: ");
                    string oldTitle = Console.ReadLine();
                    foreach(var item in ToDoCard.card){
                        if(item.Title == oldTitle){
                            item.Title = newTitle;
                            item.Content = newContent;
                            item.Member = newSelectedMember;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Please enter the old title: ");
                    string oldTitle1 = Console.ReadLine();
                    foreach(var item in InProgress.card){
                        if(item.Title == oldTitle1){
                            item.Title = newTitle;
                            item.Content = newContent;
                            item.Member = newSelectedMember;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Please enter the old title: ");
                    string oldTitle2 = Console.ReadLine();
                    foreach(var item in Done.card){
                        if(item.Title == oldTitle2){
                            item.Title = newTitle;
                            item.Content = newContent;
                            item.Member = newSelectedMember;
                        }
                    }
                    break;
                default:
                    break;
            }

       }

       public void MoveCard(){
            Console.WriteLine("Please enter the column of the card you want to move \n 1- ToDo\n 2- InProgress\n 3- Done");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the column where you want to move\n 1- ToDo\n 2-InProgress\n 3-Done");
            int newColumn = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the card's title");
            string title = Console.ReadLine();

            switch(select){
            
                case 1:

                    foreach(var item in ToDoCard.card){
                        if(item.Title == title){
                            if(newColumn == 1){
                                break;
                            }else if (newColumn == 2){
                                InProgress newCard = new InProgress(item.Title, item.Content, item.Member);
                                ToDoCard.card.Remove(item);
                                break;
                            }else{
                                Done newCard = new Done(item.Title, item.Content, item.Member);
                                ToDoCard.card.Remove(item);
                                break;
                            }
                        }
                    }
                
                    break;
                case 2:
                    foreach(var item in InProgress.card){
                        if(item.Title == title){
                            if(newColumn == 1){
                                ToDoCard newCard = new ToDoCard(item.Title, item.Content, item.Member);
                                InProgress.card.Remove(item);
                                break;
                            }else if (newColumn == 2){
                                break;
                            }else{
                                Done newCard = new Done(item.Title, item.Content, item.Member);
                                InProgress.card.Remove(item);
                                break;
                            }
                        }
                    }
                
                    break;

                case 3:
                    foreach(var item in Done.card){
                        if(item.Title == title){
                            if(newColumn == 1){
                                ToDoCard newCard = new ToDoCard(item.Title, item.Content, item.Member);
                                Done.card.Remove(item);
                                break;
                            }else if (newColumn == 2){
                                InProgress newCard = new InProgress(item.Title, item.Content, item.Member);
                                Done.card.Remove(item);
                                break;
                            }else{
                                break;
                            }
                        }
                    }
                
                    break;

            }
       }

       public void ListBoard(){

            Console.WriteLine("*****"+"\t\tToDo Line\t\t" + "*****");
            ToDoCard.list();
            Console.WriteLine("*****"+"\t\tInProgress Line\t\t" + "*****");
            InProgress.list();
            Console.WriteLine("*****"+"\t\tDone Line\t\t" + "*****");
            Done.list();

       }


       public void ListMembers(){
            Console.WriteLine("***\t\t" + "Members" + "\t\t***");
            foreach(Members members in member.Values){
                Console.WriteLine("Name: " + members.Name + "\t\t Last Name: " + members.LastName + "\t\t Id: " + members.Id );
                Console.WriteLine("-----------------");
            }
       }

    }
    
}