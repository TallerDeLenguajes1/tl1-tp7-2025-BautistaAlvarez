namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngresoEmpresa;
        private double sueldoBasico;
        private Cargos cargo;
        //ejercicio a
        public int Antiguedad //uso propiedad ya que es un calculo simple
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int antiguedad = hoy.Year - fechaIngresoEmpresa.Year;
                if (hoy.Month < fechaIngresoEmpresa.Month || hoy.Month == fechaIngresoEmpresa.Month && hoy.Day < fechaIngresoEmpresa.Day)
                {
                    antiguedad--;
                }
                return antiguedad;
            }
        }
        public int EdadEmpleado
        {
            get
            { //una manera de usar get
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - fechaNacimiento.Year;
                if (hoy.Month < fechaNacimiento.Month || hoy.Month == fechaNacimiento.Month && hoy.Day < fechaNacimiento.Day)
                {
                    edad--;
                }
                return edad;
            }
        }

        public int CantidadDeAniosFaltantes
        {
            get
            {
                int cantAniosFaltantes;
                int edadActual = EdadEmpleado;//puedo usar la propiedad para calculos
                cantAniosFaltantes = 65 - edadActual;

                if (cantAniosFaltantes < 0)
                {
                    cantAniosFaltantes = 0;
                }
                return cantAniosFaltantes;
            }
        }
        //ejercicio b
        public double Salario()
        {
            int aniosAntiguedad = Antiguedad;//aqui llamo a la propiedad antiguedad
            double adicional, total;
            if (aniosAntiguedad < 20)
            {
                adicional = sueldoBasico * ((double)aniosAntiguedad / 100);
            }
            else
            {
                adicional = sueldoBasico * 0.25;
            }
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional = adicional * 1.5;
            }
            if (estadoCivil == 'c') //C de casado y S seria de soltero
            {
                adicional += 150000;
            }
            total = sueldoBasico + adicional;
            return total;
        }
        //Ejercicio3 metodo constructor
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            fechaIngresoEmpresa = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }

        //ejercicio e
        public string Nombre
        {
            get => nombre;
        }
        public string Apellido => apellido; //otra manera de hacer una propiedad get
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
        }
        public char EstadoCivil
        {
            get => estadoCivil;
        }
        public DateTime FechaIngresoEmpresa
        {
            get => fechaIngresoEmpresa;
        }
        public double SueldoBasico
        {
            get => sueldoBasico;
        }
        public Cargos Cargo
        {
            get => cargo;
        }

        //esto es otra forma de hacer el ejercicio e, con un metodo void que escriba todos los datos
        /*
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}");
            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Edad: {EdadEmpleado} años");
            Console.WriteLine($"Estado civil: {(estadoCivil == 'c' ? "Casado" : "Soltero")}");
            Console.WriteLine($"Fecha de ingreso: {fechaIngresoEmpresa.ToShortDateString()}");
            Console.WriteLine($"Antigüedad: {Antiguedad} años");
            Console.WriteLine($"Años faltantes para jubilarse: {CantidadDeAniosFaltantes}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Sueldo básico: ${sueldoBasico:N2}");
            Console.WriteLine($"Salario total: ${Salario():N2}");
        }

        */
    }
}