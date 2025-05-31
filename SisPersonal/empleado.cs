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
        public int antiguedad //uso propiedad ya que es un calculo simple
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
        public int edadEmpleado
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

        public int cantidadDeAniosFaltantes
        {
            get
            {
                int cantAniosFaltantes;
                int edadActual = edadEmpleado;//puedo usar la propiedad para calculos
                cantAniosFaltantes = 65 - edadActual;

                if (cantAniosFaltantes < 0)
                {
                    cantAniosFaltantes = 0;
                }
                return cantAniosFaltantes;
            }
        }
        //ejercicio b
        public double salario()
        {
            int aniosAntiguedad = antiguedad;//aqui llamo a la propiedad antiguedad
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
        
        
    }
}