using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    public class BigSister
    {
        public delegate void BigSisterDelegate(List<Product> cart, List<Product> receta);
        public void Eliminar(List<Product> cart, List<Product> receta)
        {
            foreach( Product c in cart)
            {
                foreach(Product r in receta)
                {
                    if(r.Name == c.Name)
                    {
                        continue;
                    }
                    else { cart.Remove(c); }
                }
            }
        }

        public event BigSisterDelegate Reto;



        


    }


}
