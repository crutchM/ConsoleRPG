using System;
namespace rpg
{
    public abstract class IEntity
    {
        private string Class;

        public string Name { get; protected set; }
        
        public double HP {get; protected set;}

        public double MaxHP {get; protected set;}

        public double MP {get; protected set;}

        public int Strenght {get; protected set;}

        public int Gold {get; protected set;}

    }
}
    
