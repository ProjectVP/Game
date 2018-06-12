using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackermen.Classes
{
    public interface IBlock : IDisposable
    {
        System.Drawing.Color Block_Color {get;set;}
    }
}
