using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 120;
        Strength = 14;
        Intelligence = 6;
        Agility = 8;
        Speed = 13;
        Luck = 1;
    }
}