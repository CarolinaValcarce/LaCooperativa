using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCooperativa
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            double pedido, precio, precioBruto, precioDto, precioFinal; /* He considerado un solo cliente, puesto que no da número de clientes, es decir, para cada cliente habría que iniciar el programa.*/
            Console.WriteLine("Introducir los kilos de patatas vendidos al cliente");
            pedido = double.Parse(Console.ReadLine()); /*Considero que se pueden introducir los kilos con coma indicando los gramos de patatas también.*/
            Console.WriteLine("Introducir el precio de venta unitario del pedido de patatas del cliente");
            precio = double.Parse(Console.ReadLine());
            precioBruto = pedido * precio;
            Console.WriteLine("************************************************************"); /*Es un adorno de presentación.*/
            Console.WriteLine("El precio total bruto del pedido del cliente es {0} Euros", precioBruto);
            if (precioBruto < 50) {
                precioDto = precioBruto * 1;
                Console.WriteLine("Al precio total bruto del pedido no se le ofrece ningún descuento por cantidad, y es {0} Euros", precioDto);
            }
            else
            {
                if (precioBruto > 100)
                {
                    precioDto = precioBruto * 0.80;
                    Console.WriteLine("El precio del pedido con el descuento aplicado por cantidad es {0} Euros", precioDto);
                }
                else
                {
                    precioDto = precioBruto * 0.90;
                    Console.WriteLine("El precio del pedido con el descuento aplicado por cantidad es {0} Euros", precioDto);
                }
            }
            Console.WriteLine("************************************************************");
            Console.WriteLine("Elige una de las siguientes 2 opciones:");
            Console.WriteLine("0.-El cliente es un particular:");
            Console.WriteLine("1.-El cliente es una empresa:");
            opcion = char.Parse(Console.ReadLine());
            switch (opcion)
            {
                case '0':
                    precioFinal = precioDto * 1.21;
                    Console.WriteLine("El precio final del pedido con IVA es {0} Euros", precioFinal);
                    break;
                case '1':
                    precioFinal = precioDto * 1;
                    Console.WriteLine("El precio final del pedido con IVA incluido es {0} Euros", precioFinal);
                    break;
                default:
                    Console.WriteLine("La opción que has seleccionado no está disponible");
                    break;
            }
            Console.ReadLine();
        }
    }
}
