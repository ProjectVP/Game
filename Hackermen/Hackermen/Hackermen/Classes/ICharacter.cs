using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackermen.Classes
{
    public enum CharacterType
    {
        Hackermen,
        Enemy
    }
    public enum Movement
    {
        Up,
        Down,
        Left,
        Right
    }
    public interface ICharacter : IDisposable
    {
        int TotalPoints { get; set; }
        int Speed { get; set; }
        CharacterType Type { get; }
        void Move(Movement Way);
    }
}
