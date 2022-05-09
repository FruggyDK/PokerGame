using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    // Class to better handle multiple tags for a control
    internal class BetterTags
    {
        public Dictionary<string, object> TagDictionary { get; set; }

        public BetterTags()
        {
            this.TagDictionary = new Dictionary<string, object>();
        }

        public void Add(string key, object value)
        {
            this.TagDictionary.Add(key, value);
        }

        public object Get(string key)
        {
            return this.TagDictionary[key];
        }
    }
}
