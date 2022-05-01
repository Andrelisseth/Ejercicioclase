using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEnFra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BarDbEntities db = new BarDbEntities())
            {
                //InsertarProductos
                /*Producto oProducto = new Producto();
                Console.WriteLine("Nombre");
                oProducto.nomProd = Console.ReadLine();
                Console.WriteLine("descripción");
                oProducto.descripcion = Console.ReadLine();
                Console.WriteLine("precio");
                oProducto.precio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("cantidad");
                oProducto.cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("estado");
                oProducto.estado = Convert.ToInt32(Console.ReadLine());

                db.Producto.Add(oProducto);
                db.SaveChanges();*/

                //ActualizarProductos
                /*Producto oProducto = db.Producto.Find(1);
                oProducto.nomProd = "Cubatass";
                db.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();*/

                //BorrarProductos
                /*Producto oProductos = db.Producto.Find(9);
                db.Producto.Remove(oProducto);
                db.SaveChanges();*/

                var lst = db.Producto;
                foreach (var oProductos in lst)
                {
                    Console.WriteLine(oProductos.idProducto);
                }
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.Read();
            }
        }
    }
}
