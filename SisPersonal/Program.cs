// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;
Console.WriteLine("Hello, World!");
double montoTotal = 0;
//int jubilacion = 65, jubilado = 0; esto es una manera con for
Empleado? empleadpProximoJubilarse = null;
Empleado[] arregloEmpleado = new Empleado[3];
arregloEmpleado[0] = new Empleado("Juan", "Alvarez", new DateTime(2000, 4, 26), 's', new DateTime(2020, 6, 25), 500000, Cargos.Auxiliar);
arregloEmpleado[1] = new Empleado("Veronica", "Correa", new DateTime(1990, 7, 15), 'c', new DateTime(2015, 2, 10), 600000, Cargos.Especialista);
arregloEmpleado[2] = new Empleado("Pedro", "Gonzales", new DateTime(1960, 9, 5), 'c', new DateTime(1980, 11, 1), 650000, Cargos.Ingeniero);

foreach (var emp in arregloEmpleado)
{
    Console.WriteLine($"El monto del empleado {emp.Salario()}");
    montoTotal += emp.Salario();
    //ejercicio e
    if (empleadpProximoJubilarse == null || emp.CantidadDeAniosFaltantes < empleadpProximoJubilarse.CantidadDeAniosFaltantes)
    {
        empleadpProximoJubilarse = emp;
    }
}
Console.WriteLine($"El monto total pagado en sueldo es: {montoTotal}");

//ejercicio e
if (empleadpProximoJubilarse != null)
{
    Console.WriteLine("Datos del empleado mas proximo a jubilarse");
    Console.WriteLine($"Nombre y apellido: {empleadpProximoJubilarse.Nombre} {empleadpProximoJubilarse.Apellido}");
    Console.WriteLine($"Fecha nacimiento y de ingreso a la empresa: {empleadpProximoJubilarse.FechaNacimiento.ToString("dd/MM/yyyy")}, {empleadpProximoJubilarse.FechaIngresoEmpresa.ToString("dd/MM/yyyy")}");
    Console.WriteLine($"Estado civil: {(empleadpProximoJubilarse.EstadoCivil == 'c' ? "Casado" : "Soltero")}"); //aqui uso un if directo, ya que en la clase es un caracter, si es c da resultado casado y sino soltero
    Console.WriteLine($"Sueldo basico y cargo: {empleadpProximoJubilarse.SueldoBasico}, {empleadpProximoJubilarse.Cargo}");//podria colocar el if a parte pero tambien puedo aplicarlo directo
    Console.WriteLine($"Edad, antiguedad y cuantos años le falta para la jubilacion: {empleadpProximoJubilarse.EdadEmpleado}, {empleadpProximoJubilarse.Antiguedad}, {empleadpProximoJubilarse.CantidadDeAniosFaltantes}");
    Console.WriteLine($"Salario total: {empleadpProximoJubilarse.Salario()}");
}

//esto es una manera con for de hacer el ejercicio e
/*
for (int i = 0; i < arregloEmpleado.Length; i++)
{
    Console.WriteLine($"El monto del empleado {arregloEmpleado[i].Salario()}");
    montoTotal += arregloEmpleado[i].Salario();
    //Ejercicio e
    if (jubilacion > arregloEmpleado[i].CantidadDeAniosFaltantes)
    {
        jubilacion = arregloEmpleado[i].CantidadDeAniosFaltantes;
        jubilado = i;
    }
}
Console.WriteLine($"El monto total pagado en sueldo es: {montoTotal}");
//ejercicio e
Console.WriteLine("Datos del empleado mas proximo a jubilarse");
Console.WriteLine($"Nombre y apellido: {arregloEmpleado[jubilado].Nombre} {arregloEmpleado[jubilado].Apellido}");
Console.WriteLine($"Fecha nacimiento y de ingreso a la empresa: {arregloEmpleado[jubilado].FechaNacimiento}, {arregloEmpleado[jubilado].FechaIngresoEmpresa}");
Console.WriteLine($"Estado civil: {arregloEmpleado[jubilado].EstadoCivil}");
Console.WriteLine($"Sueldo basico y cargo: {arregloEmpleado[jubilado].SueldoBasico}, {arregloEmpleado[jubilado].Cargo}");
Console.WriteLine($"Edad, antiguedad y cuantos años le falta para la jubilacion: {arregloEmpleado[jubilado].EdadEmpleado}, {arregloEmpleado[jubilado].Antiguedad}, {arregloEmpleado[jubilado].CantidadDeAniosFaltantes}");
Console.WriteLine($"Salario total: {arregloEmpleado[jubilado].Salario()}");
*/
