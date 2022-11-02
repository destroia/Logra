using System;
using System.Collections.Generic;
using System.Text;

namespace LograModel
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Guid IdUser { set; get; }
        public Guid IdQuestion { set; get; }
        public string Pregunta { set; get; }
        public string Respuesta { set; get;  }
        public DateTime Fecha { set; get; }
    }
}
