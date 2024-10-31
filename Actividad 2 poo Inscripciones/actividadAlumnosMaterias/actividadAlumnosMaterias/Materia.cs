using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadAlumnosMaterias
{
     class Materia
    {

        #region Atributos
        private string nombre;
        #endregion

        #region Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        #endregion

        #region Constructor
        public Materia() 
        { nombre = null; }
        public Materia(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        /*#region Metodos
        public override string ToString()
        {
            return string.Concat(nombre);
        }

        #endregion*/
    }
}
