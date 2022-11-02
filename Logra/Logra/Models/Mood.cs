using System;
using System.Collections.Generic;
using System.Text;

namespace LograModel
{
    public class Mood
    {
        public Guid Id { set; get; }
        public Guid IdUser { set; get; }
        public Guid IdInstitution { set; get; }
        public Guid IdGarden { set; get; }
        public string Emocion { set; get; }
        public string Palabra { set; get; }
        public string Detonante { set; get; }
        public DateTime Fecha { set; get; }
    }
}
