using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    { 
        private string _name {get;set;}
        private int _cedula {get;set;}
        private int _edad {get;set;}
        private int _telefono {get;set;}
        private DateTime _date {get;set;}
        private string _lugar {get;set;}
        private string _doctor {get;set;}
        private string _especialidad {get;set;}

        public AppointmentService(string name, int cedula, int edad, int telefono, DateTime date, string lugar, string doctor, string especialidad)
        {
            this._name = name;
            this._cedula = cedula;
            this._edad = edad;
            this._telefono = telefono;
            this._date = date;
            this._lugar = lugar;
            this._doctor = doctor;
            this._especialidad = especialidad;

            Paciente paciente = new Paciente(this._name,this._cedula,this._edad,this._telefono);
            Doctor doctor = new Doctor(this._doctor,this._especialidad);
        }

        public bool IsValidD(DateTime date, string lugar)
        {
            if (string.IsNullOrEmpty(lugar) & string.IsNullOrEmpty(date))
            {isValid = false;}
            else{IsValid=true;}
            return IsValid;
        }
        /*
        public string Verifica()
        {
        if (cita.IsValid = true & paciente.IsValid = true)
        {

        }
        }
        */
    }

}
