using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4updated
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        /*Private Instance Variables: _oxygen (bool)     */
        private bool _oxygen;

        /*constructor*/
        //The constructor Method should take all the parameters of the Planet base class as well as 
        //oxygen as a local variable andset therelated instance variable(_oxygen) to its value
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
        : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        //Implement the HasMoons method that will return true if the MoonCount property is greater than zero
        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;

        }

        //Implement the Habitable method that will return true if the oxygen instance variable is set to true
        public bool Habitable()
        {
            return (this._oxygen == true) ? true : false;
        }
    }
}