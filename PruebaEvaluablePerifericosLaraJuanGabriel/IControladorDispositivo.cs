using System;

namespace PruebaEvaluablePerifericosLaraJuanGabriel
{

    // Interfaz contractual que define el comportamiento base 
    // para cualquier controlador de periféricos de entrada.
    public interface IControladorDispositivo
    {
        // Propiedad de solo lectura para obtener el nombre del dispositivo
        string Nombre { get; }

        // Propiedad que indica si el dispositivo está operativo
        bool Disponible { get; }

        // Método obligatorio para restablecer las métricas y contadores a cero
        void Reiniciar();

        // Método para devolver una cadena de texto con el estado del hardware
        string ObtenerEstado();
    }
}