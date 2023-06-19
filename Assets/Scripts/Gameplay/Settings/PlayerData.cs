using System;

namespace Rummicub.Gameplay.Settings
{
    [Serializable]
    public class PlayerData
    {
        public string Name { get; set; }

        public PlayerData(string name)
        {
            Name = name;
        }

        public PlayerData() : this(null)
        {
        }

        public override string ToString()
        {
            return $"Player: {Name}";
        }
    }
}
