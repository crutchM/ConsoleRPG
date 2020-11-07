using System;
using System.Collections.Generic;
namespace rpg
{
    public class Item
    {
        public string Name{get; }
        
        public readonly Dictionary<string, int> Characteristics = new Dictionary<string, int>();

        public Item(string name, List<string> charasteristics, List<int> count) 
        {
            Name = name;
            AddAllCharasteristics(charasteristics, count);
        }  

        private void AddAllCharasteristics(List<string> charasteristics, List<int> count)
        {
            if(charasteristics.Count != count.Count)
                throw new Exception();
            for(int i = 0; i < charasteristics.Count; i++)
                Characteristics.Add(charasteristics[i], count[i]);
        }

    
        

    }
}