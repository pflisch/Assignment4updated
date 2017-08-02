using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4updated
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        /*a. Private Instance Variables: _type(string)
         * which willhold astring thatdescribes thetype ofGiant Planet(either“Gas” or“Ice”)*/
        private string _type;

        /*constructors*/

        //b.The constructor Method should take all the parameters of the Planet base class as well 
        //as type as a local variable and set the related instance variable(_type) to its value

        public GiantPlanet(string name, double diameter, double mass, string type)
        : base(name, diameter, mass)
        {
            this._type = type;
        }

        /*interface*/

        //c.Implement theHasMoons methodthat willreturn true if the MoonCountproperty is greater than zero
        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;
        }

        //d.Implement the HasRings method that will return true if the RingCountproperty is greater than zero
        public bool HasRings()
        {
            return (RingCount > 0) ? true : false;
        }
    }
}






