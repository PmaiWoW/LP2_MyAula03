using System;
using System.Collections.Generic;
using System.Text;

namespace MyInterfaces
{
    interface IHasScore : IEquatable<IHasScore>
    {
        int Score { get; }
    }
}
