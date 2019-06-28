using System;

namespace Day4
{
    struct Players
    {
        public string playerName { get; set; }
        public int Num { get; set; }
        public int Age { get; set; }
        public string Tel { get; set; }

        public Players(string _playerName, int _Num, int _Age, string _Tel)
        {
            playerName = _playerName;
            Num = _Num;
            Age = _Age;
            Tel = _Tel;
        }
        public void playersPrint()
        {
            Console.WriteLine($"PlayerName: {playerName}, PlayerNUm: {Num}, PlayerAge: {Age}, PlayerTel: {Tel}");
        }
    }
    struct Team
    {
        public string teamName { get; set; }
        public int Id { get; set; }
        public string couchName { get; set; }
        public Players [] players { get; set; }
        public Team(string _couchName, string _teamName, int _Id, Players[] _players)
        {
            teamName = _teamName;
            Id = _Id;
            couchName = _couchName;
            players = _players;
        }
        public void teamPrint()
        {
            Console.WriteLine($"TeamName: {teamName}, TeamIDL: {Id}, CouchName: {couchName}");
            for (int i = 0; i < players.Length; i++)
            {
                players[i].playersPrint();
            }
        }


        public string this [int num]
        {
            get
            {
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].Num==num)
                    {
                        return players[i].playerName;
                    }
                    
                }
                return "";
            }

            set 
            {
                for (int i = 0; i < players.Length; i++)
                    if (players[i].Num==num)
                {
                    players[i].playerName = value;
                }
                
            }

            }


    }
    class Test1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Player Number: ");
            int PlayerNumber =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name: ");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("Enter Player Age: ");
            int PlayerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Telephone: ");
            string PlayerTelephone = Console.ReadLine();
            Players[] playersStruct = new Players[] { new Players(PlayerName, PlayerNumber, PlayerAge, PlayerTelephone)} ;




            Console.WriteLine("Enter Couch Name: ");
            string CouchName = Console.ReadLine();
            Console.WriteLine("Enter Team Name: ");
            string TeamName = Console.ReadLine();
            Console.WriteLine("Enter Team Number: ");
            int TeamNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Player Telephone: ");

            
            Team team1 = new Team(CouchName, TeamName, TeamNumber, playersStruct);
            Players player = new Players();
            
            Console.WriteLine("Enter Number to search of Player");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Name of Player");
            string Name = Console.ReadLine();
            player.playerName = Name;
            Console.WriteLine($"The  name of Player is :  { team1[num] = PlayerName }");
            team1[num] = Name;
            Console.WriteLine("The new name of Player is : " + player.playerName ); 
        
        }

    }
}
