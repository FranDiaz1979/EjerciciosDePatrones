using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IValidadorStrategy
    {
        bool Validar(Peticion peticion);
    }
}
