using System;
using System.Drawing;       // Necesario para el tipo de datos espacial 'Point'
using System.Windows.Forms; // Necesario para interactuar con la enumeración 'MouseButtons'

namespace PruebaEvaluablePerifericosLaraJuanGabriel
{

    // Clase encargada de registrar la posición y los clics del mouse.
    // Implementa de forma estricta la interfaz IControladorDispositivo.

    public class RatonControlador : IControladorDispositivo
    {
        // Propiedades heredadas de la interfaz común
        public string Nombre => "Ratón";
        public bool Disponible { get; private set; } = true;

        // Métricas de monitorización del ratón
        public int PosicionX { get; private set; } = 0;
        public int PosicionY { get; private set; } = 0;
        public string UltimoBoton { get; private set; } = "Ninguno";
        public int Clics { get; private set; } = 0;


        // Actualiza las coordenadas bidimensionales cartesianas del puntero en pantalla.
        public void ProcesarMovimiento(Point posicion)
        {
            PosicionX = posicion.X; // Guarda el valor del eje horizontal
            PosicionY = posicion.Y; // Guarda el valor del eje vertical
        }

  
        // Registra el botón del ratón presionado e incrementa el contador general de clics.
        public void ProcesarClic(MouseButtons boton)
        {
            UltimoBoton = boton.ToString(); // Mapea si es Left, Right o Middle click
            Clics++;                        // Incrementa el acumulador total de clics
        }


        // Limpia las métricas acumuladas y devuelve el ratón a su estado original.
        public void Reiniciar()
        {
            PosicionX = 0;
            PosicionY = 0;
            UltimoBoton = "Ninguno";
            Clics = 0;
            Disponible = true;
        }

        /// <summary>
        /// Devuelve una cadena con la disponibilidad actual del ratón.
        /// </summary>
        public string ObtenerEstado()
        {
            return Disponible ? "ACTIVO" : "NO DISPONIBLE";
        }
    }
}