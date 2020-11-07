namespace rpg
{
    public abstract class Room
    {
        private readonly Room[] _nextRooms = new Room[4]; // Forward, Back, Left, Right

        public bool HasNextRoom(Direction dir) => _nextRooms[(int)dir] == null;

        private void PresetRooms()
        {
            
        }

    }
}