using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public Paciente(string name,string numCedula,string numEdad, string telefono)
        {
            _nombre = name;
            _cedula = numCedula;
            _edad = numEdad;
            _telefono = telefono;
        }
        private string _nombre {get;set;}
        private string _cedula {get;set;}
        private string _edad {get;set;}
        private string _telefono {get;set;}
        public bool IsValidP()
        {
            if (string.IsNullOrEmpty(_nombre) | string.IsNullOrEmpty(_cedula) | string.IsNullOrEmpty(_edad) | string.IsNullOrEmpty(_telefono))
            {
                IsValid = false;
            }else{IsValid = true;}
            return IsValid;
        }
        
    }
}