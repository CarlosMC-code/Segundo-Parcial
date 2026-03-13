namespace segundo_parcial
{

    using System;

    class producto
    {
        private string nombre;
        private string codigo;
        private double precio;
        private int cantidad;

        public producto(string nombre, string codigo, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public virtual void mostrarproducto()
        {
            Console.WriteLine("Producto: " + nombre);
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Cantidad: " + cantidad);
        }

        public virtual double Cimpuestos()
        {
            return 0;
        }
    }

    class ProductoE : producto
    {
        private int GarantiaM;

        public ProductoE(string nombre, string codigo, double precio, int cantidad, int GarantiaM)
            : base(nombre, codigo, precio, cantidad)
        {
            this.GarantiaM = GarantiaM;
        }

        public override void mostrarproducto()
        {
            base.mostrarproducto();
            Console.WriteLine("Garantia: " + GarantiaM + " meses");
        }

        public override double Cimpuestos()
        {
            return Precio * 0.18;
        }
    }

    class ProductoA : producto
    {
        private string FechaV;

        public ProductoA(string nombre, string codigo, double precio, int cantidad, string FechaV)
            : base(nombre, codigo, precio, cantidad)
        {
            this.FechaV = FechaV;
        }

        public override void mostrarproducto()
        {
            base.mostrarproducto();
            Console.WriteLine("Fecha de vencimiento: " + FechaV);
        }

        public override double Cimpuestos()
        {
            return Precio * 0.08;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Sistema de inventarios---");
            Console.WriteLine("1. productos eltronicos");
            Console.WriteLine("2. productos de alimentos ");
            Console.Write("Selecciona una opcion: ");
            Console.WriteLine();

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion != 1 && opcion != 2)
            {
                Console.WriteLine("Opcion no valida");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Codigo: ");
            string codigo = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Garantia en meses: ");
                int garantia = Convert.ToInt32(Console.ReadLine());

                ProductoE producto = new ProductoE(
                    nombre, codigo, precio, cantidad, garantia);

                Console.WriteLine("\n---Informacion del producto---");
                producto.mostrarproducto();
                Console.WriteLine("Impuesto: " + producto.Cimpuestos());
            }
            else
            {
                Console.Write("Fecha de vencimiento: ");
                string fecha = Console.ReadLine();

                ProductoA producto = new ProductoA(
                    nombre, codigo, precio, cantidad, fecha);

                Console.WriteLine("\n---Informacion del producto---");
                producto.mostrarproducto();
                Console.WriteLine("Impuesto: " + producto.Cimpuestos());
            }

        }
    }










}
