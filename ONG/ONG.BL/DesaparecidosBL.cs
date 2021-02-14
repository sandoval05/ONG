using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.BL
{
    public class DesaparecidosBL
    {
        public List<Desaparecido> ObtenerDesaparecido()
        {
            var desaparecido1 = new Desaparecido();
            desaparecido1.Id = 1;
            desaparecido1.PNombre = "Nelson";
            desaparecido1.SNombre = "Alejandro";
            desaparecido1.PApellido = "Sandoval";
            desaparecido1.SApellido = "Reyes";
            desaparecido1.Residencia = "El Progreso";
            desaparecido1.Edad = 22;
            desaparecido1.Genero = "M";

            var desaparecido2 = new Desaparecido();
            desaparecido2.Id = 1;
            desaparecido2.PNombre = "Gerson";
            desaparecido2.SNombre = "Alejandro";
            desaparecido2.PApellido = "Sandoval";
            desaparecido2.SApellido = "Reyes";
            desaparecido2.Residencia = "yoro";
            desaparecido2.Edad = 22;
            desaparecido2.Genero = "F";

            var listaDesaparecidos = new List<Desaparecido>();
            listaDesaparecidos.Add(desaparecido1);
            listaDesaparecidos.Add(desaparecido2);

            return listaDesaparecidos;
          }
    }
}
