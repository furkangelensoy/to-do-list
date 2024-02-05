namespace ToDo{
    public static class DefaultMembers{

        private static Dictionary<int,Members> defaultMember = new Dictionary<int, Members>();
        public static Dictionary<int,Members> DefaultTeamMembers(){
            
            defaultMember.Add(1, new Members("Everett","Williams",1));
            defaultMember.Add(2, new Members("Silvia","Harris",2));
            defaultMember.Add(3, new Members("Orlando","Thomas",3));
            defaultMember.Add(4, new Members("Blanca","Robinson",4));
            defaultMember.Add(5, new Members("Marshall","Walker",5));
            defaultMember.Add(6, new Members("Patricia","Scott",6));
            defaultMember.Add(7, new Members("Stefan","Nelson",7));
            defaultMember.Add(8, new Members("Janessa","Mitchell",8));
            defaultMember.Add(9, new Members("Benjamin","Morgan",9));
            defaultMember.Add(10,new Members("Claudia","Cooper",10));
            
            return defaultMember;
        
        }

    }

}
