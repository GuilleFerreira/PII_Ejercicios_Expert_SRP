using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Gaston Martinez","34423333","43","091099098");
            
            if (paciente1.IsValid() == true)
            {
                CreadorCitas cita = new CreadorCitas(paciente1.nombre,paciente1.cedula,paciente1.edad,paciente1.telef,"Medica Uruguaya", "DR Martinez","Psiquiatra","17/12/2021");
                if (cita.IsValid() == true)
                {
                    cita.Confirmacion();
                }
            }

            //string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            //Console.WriteLine(appointmentResult);
        }
    }
}
