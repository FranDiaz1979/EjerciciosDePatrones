using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ValidadorPeticiones
    {
        private IValidadorStrategy validadorStrategy;

        public void SetStrategy(IValidadorStrategy validadorStrategyParam)
        {
            this.validadorStrategy = validadorStrategyParam;
        }

        public bool Validar(Peticion peticion)
        {
            if (validadorStrategy==null)
            {
                throw new ArgumentNullException(nameof(validadorStrategy));
            }
            return this.validadorStrategy.Validar(peticion);
        }

        /* Un método de validación por cada tipo de petición */
    }
}
