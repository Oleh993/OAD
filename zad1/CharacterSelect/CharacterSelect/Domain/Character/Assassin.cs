using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Assassin : Entity.Character
{
    public Assassin(string name) : base(name, CharacterClass.Assassin)
    {
        Health = 90;
        Strength = 9;
        Intelligence = 8;
        Agility = 8;
        Speed = 12;
        Luck = 1;
    }
}