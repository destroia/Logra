using System;
using System.Collections.Generic;
using System.Text;

namespace LograModel
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Pregunta { set; get; }
        public bool IsSlider { set; get; }
        public DateTime Fecha { set; get; }

    }
}
