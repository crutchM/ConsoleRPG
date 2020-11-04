using System;

public class Player
{

    private string Class;

    public readonly string Name;
    public double HP {get; private set;}

    public double MaxHP {get; private set;}

    public double MP {get; private set;}

    public int Strenght {get; private set;}

    public int Gold {get; private set;}

    public Player(string name, string playerClass)
    {
        Name = name;
        SetStartCharacteristics(playerClass);
    }

    private void SetStartCharacteristics(string cl)
    {
        switch (cl)
        {
            case "mage":
                HP = 100;
                MP = 150;
                MaxHP = 100;
                Strenght = 10;
                Gold = 100;
                break;
            case "barbarian":
                HP = 150;
                MP = 30;
                MaxHP = 150;
                Strenght = 40;
                Gold = 100;
                break;
            case "thief":
                HP = 70;
                MP = 80;
                MaxHP = 70;
                Strenght = 20;
                Gold = 200;
                break;
        }
    }
}