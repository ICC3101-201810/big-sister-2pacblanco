using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    public class BigSister
    {
        public BigSister()
        {
            Reto += new BigSisterDelegate(Remover);
        }
        public delegate void BigSisterDelegate(List<Product> cart, List<Product> receta);
        public void Eliminar(List<Product> cart, List<Product> receta)
        {
            if(cart.Count()>= receta.Count())
            {
                Reto(cart, receta);
            }
            else { Reto(cart, receta); }
        }

        public event BigSisterDelegate Reto;

        public void Remover(List<Product> cart,List<Product> receta)
        {
            foreach (Product c in cart)
            {
                foreach (Product r in receta)
                {
                    if (r.Name == c.Name)
                    {
                        continue;
                    }
                    else {
                        Console.WriteLine("Retado por la hermana grande");
                        cart.Remove(c); }
                }
            }

        }



        


    }


}
