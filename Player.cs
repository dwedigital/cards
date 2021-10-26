namespace cards{

    class Player{
        public string Name { get; private set;}
        public Hand Hand { get; set; } = null;

        public Player(string name){
            this.Name = name;
        }

    }
}