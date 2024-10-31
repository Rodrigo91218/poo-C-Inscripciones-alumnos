using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_
{
     class Inscripcion
    {
        #region Atributos
        private int añoLectivo;
        private Materia materia;
        private Alumno alumno;
        private bool aprobado;
        #endregion

        #region Propiedades
        public int AñoLectivo { get { return añoLectivo; } set { añoLectivo = value; } }
        public Materia Materia { get { return materia; } set { materia = value; } }
        public Alumno Alumno { get { return alumno; } set { alumno = value; } }
        public bool Aprobado { get { return aprobado; } set { aprobado = value; } }
        #endregion

        #region Constructor
        public Inscripcion(int añoLectivo, Materia materia, Alumno alumno, bool aprobado)
        {
            this.añoLectivo = añoLectivo;
            this.materia = materia;
            this.alumno = alumno;
            this.aprobado = aprobado;
        }

        public Inscripcion()
        {
            this.añoLectivo = 2024;
            this.materia = null;
            this.alumno = null;
            this.aprobado = false;
        }
        #endregion
    }
}
