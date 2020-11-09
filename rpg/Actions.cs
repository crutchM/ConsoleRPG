using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using static rpg.Actions.FightActions;

namespace rpg
{
    public class Actions
    {
        public enum WorldActions
        {
            fight,
            search,
            goForward,
            goBack,
            goLeft,
            goRight,
            evadeFight,
        };

        public enum FightActions
        {
            bonk,
            block,
            leaveFIght,
            heal
        };

        private int rndarr;
        
        public Dictionary<WorldActions, Actions> act = new Dictionary<WorldActions,Actions>();
        
        private Dictionary<FightActions, Actions> fact = new Dictionary<FightActions,Actions>();
        
        private void BeginFight(string e)
        {
            switch (Enum.Parse(typeof(FightActions), e))
            {
                case FightActions.bonk:
                
                    break;
                case FightActions.block :
                    break;
                case FightActions.heal :
                    break;
                case FightActions.leaveFIght :
                    break;
                
            }
        }

        private int CaculateBonk(Player player, Enemy enemy)
        {
            int sumWeaponDamage = 0;
            foreach (var e in player.equipedItems) 
            {
                if (e.Type == "Weapon")
                    sumWeaponDamage += e.Characteristics["damage"];
            }
            double criticalChanse = 0;
            int playerDamage = player.Strenght + sumWeaponDamage;
            var totalDamage = (int)CalculateCriticalDamage(player, enemy, playerDamage);
            return totalDamage;
        }
        private double CalculateCriticalDamage(Player player, Enemy enemy, int playerDamage)
        {
            double criticalDamage = 0.5;
            double criticalChanse = 0;
            foreach (var e in player.equipedItems)
            {
                if (e.Type == "weapon")
                    criticalChanse += e.Characteristics["Critical Damage Chanse"] / 100;
            }

            if (criticalChanse <= 0.25)
                rndarr = 3;
            else if (criticalChanse <= 0.5)
                    rndarr = 2;
            else if (criticalChanse <= 0.75)
                    rndarr = 1;
            else rndarr = 0;
            Random end = new Random();
            return playerDamage + (end.Next(rndarr) == 0 ? playerDamage * 0.5 : playerDamage * 0);
        }
    }
}