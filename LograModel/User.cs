using System;
using System.Collections.Generic;
using System.Text;

namespace LograModel
{
    public class User
    {
        public Guid Id { set; get; }
        public Guid IdGarden { set; get; }
        public Guid IdInstutition { set; get; }
        public string UserName { get; set; }
        public string Niup { set; get; }
        public string Contraseña { set; get; }
        public string Direccion { get; set; }
        public string Acudiente { get; set; }
        public string Codigo { get; set; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Etnia { set; get; }
        public string Edad { set; get; }
        public string Sexo { set; get; }
        public string Email { set; get; }
        public string Celular { set; get; }
        public int Emocion1 { set; get; }
        public int Emocion2 { set; get; }
        public int Emocion3 { set; get; }
        public int Emocion4 { set; get; }
        public int Emocion5 { set; get; }


    }
}
