using System;

namespace rpg
{
    class Enemy : IEntity
    {
        public Enemy(string name, string cl)
        {
            SetStartCharacteristics(cl);
        }

        private void SetStartCharacteristics(string cl)
        {
            switch (cl)
            {
                case "mage":
                    Name = "mage";
                    HP = 100;
                    MP = 150;
                    MaxHP = 100;
                    Strenght = 10;
                    Gold = 100;
                    break;
                case "barbarian":
                    Name = "barbarian";                    
                    HP = 150;
                    MP = 30;
                    MaxHP = 150;
                    Strenght = 40;
                    Gold = 100;
                    break;
                case "thief":
                    Name = "thief";
                    HP = 70;
                    MP = 80;
                    MaxHP = 70;
                    Strenght = 20;
                    Gold = 200;
                    break;
            }
        }       
    }
}