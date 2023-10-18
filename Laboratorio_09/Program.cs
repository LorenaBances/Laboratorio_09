using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal caja = 0;

            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar venta de Limpieza");
                Console.WriteLine("2: Registrar devolución de Abarrotes");
                Console.WriteLine("3: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("================================");
                    Console.Write("Ingrese cantidad (unidades): ");
                    int cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese precio: S/ ");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    decimal total = cantidad * precio;
                    caja += total;

                    Console.WriteLine("================================");
                    Console.WriteLine($"Se han ingresado {cantidad} unidades");
                    Console.WriteLine($"Se han ingresado S/ {total:N2} en caja");
                    Console.WriteLine("================================");

                    Console.WriteLine("1: Registrar más productos de limpieza");
                    Console.WriteLine("2: <- Regresar");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");
                    int subOpcion = int.Parse(Console.ReadLine());

                    if (subOpcion == 2)
                    {
                        continue;
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("================================");
                    Console.Write("Ingrese cantidad (unidades): ");
                    int cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese precio: S/ ");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    decimal total = cantidad * precio;
                    caja -= total;

                    Console.WriteLine("================================");
                    Console.WriteLine($"Se han regresado {cantidad} unidades");
                    Console.WriteLine($"Se han devuelto S/ {total:N2} de caja");
                    Console.WriteLine("================================");

                    Console.WriteLine("1: Devolver más productos de abarrotes");
                    Console.WriteLine("2: <- Regresar");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");
                    int subOpcion = int.Parse(Console.ReadLine());

                    if (subOpcion == 2)
                    {
                        continue;
                    }
                }
                else if (opcion == 3)
                {
                    break;
                }

            }
        }
    }
    internal class Progra
    {
        static void Main()
        {
            int cajaTotal = 0;
            int centavosPorSol = 100; // 100 centavos equivalen a 1 sol
            int ventasLimpieza = 0;
            int devolucionesLimpieza = 0;
            int ventasAbarrotes = 0;
            int devolucionesAbarrotes = 0;
            int ventasGolosinas = 0;
            int devolucionesGolosinas = 0;
            int ventasElectro = 0;
            int devolucionesElectro = 0;

            Console.WriteLine("================================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("================================");

            while (true)
            {
                Console.WriteLine("1: Registrar venta");
                Console.WriteLine("2: Registrar devolución");
                Console.WriteLine("3: Cerrar Caja");
                Console.WriteLine("================================");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el tipo de producto (Limpieza, Abarrotes, Golosinas, Electro):");
                        string tipoProducto = Console.ReadLine();
                        Console.WriteLine("Ingrese el monto de la venta en soles:");
                        int montoVentaSoles = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto de la venta en centavos:");
                        int montoVentaCentavos = int.Parse(Console.ReadLine());

                        int montoVentaTotal = (montoVentaSoles * centavosPorSol) + montoVentaCentavos;

                        switch (tipoProducto)
                        {
                            case "Limpieza":
                                ventasLimpieza++;
                                cajaTotal += montoVentaTotal;
                                break;
                            case "Abarrotes":
                                ventasAbarrotes++;
                                cajaTotal += montoVentaTotal;
                                break;
                            case "Golosinas":
                                ventasGolosinas++;
                                cajaTotal += montoVentaTotal;
                                break;
                            case "Electro":
                                ventasElectro++;
                                cajaTotal += montoVentaTotal;
                                break;
                            default:
                                Console.WriteLine("Tipo de producto no válido.");
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el tipo de producto (Limpieza, Abarrotes, Golosinas, Electro):");
                        string tipoProductoDevolucion = Console.ReadLine();
                        Console.WriteLine("Ingrese el monto de la devolución en soles:");
                        int montoDevolucionSoles = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto de la devolución en centavos:");
                        int montoDevolucionCentavos = int.Parse(Console.ReadLine());

                        int montoDevolucionTotal = (montoDevolucionSoles * centavosPorSol) + montoDevolucionCentavos;

                        switch (tipoProductoDevolucion)
                        {
                            case "Limpieza":
                                devolucionesLimpieza++;
                                cajaTotal -= montoDevolucionTotal;
                                break;
                            case "Abarrotes":
                                devolucionesAbarrotes++;
                                cajaTotal -= montoDevolucionTotal;
                                break;
                            case "Golosinas":
                                devolucionesGolosinas++;
                                cajaTotal -= montoDevolucionTotal;
                                break;
                            case "Electro":
                                devolucionesElectro++;
                                cajaTotal -= montoDevolucionTotal;
                                break;
                            default:
                                Console.WriteLine("Tipo de producto no válido.");
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine("================================");
                        Console.WriteLine("Cerrando Caja");
                        Console.WriteLine("================================");

                        Console.WriteLine("| " + ventasLimpieza + " vendidos");
                        Console.WriteLine("Limpieza | " + devolucionesLimpieza + " devueltos");
                        Console.WriteLine("| " + (ventasLimpieza - devolucionesLimpieza) + " en total");
                        Console.WriteLine("| S/ " + (ventasLimpieza - devolucionesLimpieza) / centavosPorSol + "." + (ventasLimpieza - devolucionesLimpieza) % centavosPorSol + " en caja");
                        Console.WriteLine("================================");

                        Console.WriteLine("| " + ventasAbarrotes + " vendidos");
                        Console.WriteLine("Abarrotes | " + devolucionesAbarrotes + " devueltos");
                        Console.WriteLine("| " + (ventasAbarrotes - devolucionesAbarrotes) + " en total");
                        Console.WriteLine("| S/ " + (ventasAbarrotes - devolucionesAbarrotes) / centavosPorSol + "." + (ventasAbarrotes - devolucionesAbarrotes) % centavosPorSol + " en caja");
                        Console.WriteLine("================================");

                        Console.WriteLine("| " + ventasGolosinas + " vendidos");
                        Console.WriteLine("Golosinas | " + devolucionesGolosinas + " devueltos");
                        Console.WriteLine("| " + (ventasGolosinas - devolucionesGolosinas) + " en total");
                        Console.WriteLine("| S/ " + (ventasGolosinas - devolucionesGolosinas) / centavosPorSol + "." + (ventasGolosinas - devolucionesGolosinas) % centavosPorSol + " en caja");
                        Console.WriteLine("================================");

                        Console.WriteLine("| " + ventasElectro + " vendidos");
                        Console.WriteLine("Electro | " + devolucionesElectro + " devueltos");
                        Console.WriteLine("| " + (ventasElectro - devolucionesElectro) + " en total");
                        Console.WriteLine("| S/ " + (ventasElectro - devolucionesElectro) / centavosPorSol + "." + (ventasElectro - devolucionesElectro) % centavosPorSol + " en caja");
                        Console.WriteLine("================================");

                        Console.WriteLine("Queda en caja S/ " + cajaTotal / centavosPorSol + "." + cajaTotal % centavosPorSol);
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }


    class Producto
    {
        public string Nombre { get; set; }
        public int Vendidos { get; set; }
        public int Devueltos { get; set; }
        public decimal Precio { get; set; }
    }
    internal class Progr

    {
        static List<Producto> productos = new List<Producto>();
        static void main(string[] args)
        {
            InicializarProductos();
            bool cajaCerrada = false;

            while (!cajaCerrada)
            {
                MostrarMenu();
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarVenta();
                        break;
                    case 2:
                        RegistrarDevolucion();
                        break;
                    case 3:
                        CerrarCaja();
                        cajaCerrada = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void InicializarProductos()
        {
            productos.Add(new Producto { Nombre = "Limpieza", Vendidos = 0, Devueltos = 0, Precio = 7.00m });
            productos.Add(new Producto { Nombre = "Abarrotes", Vendidos = 0, Devueltos = 0, Precio = 3.00m });
            productos.Add(new Producto { Nombre = "Golosinas", Vendidos = 0, Devueltos = 0, Precio = 2.00m });
            productos.Add(new Producto { Nombre = "Electro", Vendidos = 0, Devueltos = 0, Precio = 14.83m });
        }

        static void MostrarMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("================================");
        }

        static void RegistrarVenta()
        {
            Console.WriteLine("Ingrese el número del producto (1 - 4):");
            int numeroProducto = int.Parse(Console.ReadLine()) - 1;

            if (numeroProducto >= 0 && numeroProducto < productos.Count)
            {
                Console.WriteLine("Ingrese la cantidad vendida:");
                int cantidadVendida = int.Parse(Console.ReadLine());
                productos[numeroProducto].Vendidos += cantidadVendida;
            }
            else
            {
                Console.WriteLine("Producto no válido.");
            }
        }

        static void RegistrarDevolucion()
        {
            Console.WriteLine("Ingrese el número del producto (1 - 4):");
            int numeroProducto = int.Parse(Console.ReadLine()) - 1;

            if (numeroProducto >= 0 && numeroProducto < productos.Count)
            {
                Console.WriteLine("Ingrese la cantidad devuelta:");
                int cantidadDevuelta = int.Parse(Console.ReadLine());
                productos[numeroProducto].Devueltos += cantidadDevuelta;
            }
            else
            {
                Console.WriteLine("Producto no válido.");
            }
        }

        static void CerrarCaja()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Cerrando Caja");
            Console.WriteLine("================================");

            decimal totalCajaGeneral = 0m;

            foreach (var producto in productos)
            {
                int vendidos = producto.Vendidos;
                int devueltos = producto.Devueltos;
                int total = vendidos - devueltos;
                decimal cantidadEnCaja = total * producto.Precio;
                totalCajaGeneral += cantidadEnCaja;

                Console.WriteLine($"| {vendidos} vendidos");
                Console.WriteLine($"{producto.Nombre} | {devueltos} devueltos");
                Console.WriteLine($"| {total} en total");
                Console.WriteLine($"| S/ {cantidadEnCaja.ToString("0.00")} en caja");
                Console.WriteLine("================================");
            }

            Console.WriteLine($"Queda en caja S/ {totalCajaGeneral.ToString("0.00")}");
        }
    }
}
    
 

