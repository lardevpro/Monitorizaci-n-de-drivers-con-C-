using System;
using System.Windows.Forms; // Necesario para hacer uso de la enumeración Keys nativa

namespace PruebaEvaluablePerifericosLaraJuanGabriel
{
 
    // Clase encargada de gestionar y clasificar la actividad del teclado.
    // Implementa de forma estricta la interfaz IControladorDispositivo.
    public class TecladoControlador : IControladorDispositivo
    {
        // Propiedades requeridas por el contrato de la interfaz
        public string Nombre => "Teclado";
        public bool Disponible { get; private set; } = true;

        // Métricas de monitorización del teclado
        public string UltimaTecla { get; private set; } = "Ninguna";
        public int Codigo { get; private set; } = 0;
        public int Pulsaciones { get; private set; } = 0;
        public string TipoTecla { get; private set; } = "Sin Tipo";

       
        // Procesa la pulsación de una tecla incrementando contadores y salvando su estado.
        public void ProcesarTecla(Keys tecla)
        {
            try
            {
                UltimaTecla = tecla.ToString(); // Convierte el enumerado a texto legible
                Codigo = (int)tecla;            // Convierte el valor de la tecla a su código numérico
                Pulsaciones++;                  // Incrementa el acumulador total de pulsaciones

                // Clasifica automáticamente el tipo de tecla pulsada
                DetectarTipoTecla(tecla);
            }
            catch (Exception)
            {
                // Gestión de errores: Si el procesamiento falla, se resguarda el estado de la aplicación
                TipoTecla = "Sin Tipo";
            }
        }

        
        // Evalúa la tecla pulsada mediante rangos lógicos para determinar su categoría.
        public void DetectarTipoTecla(Keys tecla)
        {
            // Comprobación de números en la fila estándar (D0-D9) y en el teclado numérico (NumPad0-NumPad9)
            if ((tecla >= Keys.D0 && tecla <= Keys.D9) || (tecla >= Keys.NumPad0 && tecla <= Keys.NumPad9))
            {
                TipoTecla = "Número";
            }
            // Comprobación de letras dentro del abecedario estándar (A-Z)
            else if (tecla >= Keys.A && tecla <= Keys.Z)
            {
                TipoTecla = "Letra";
            }
            // Cualquier otra tecla del sistema (Enter, Shift, Barra espaciadora, flechas, etc.)
            else
            {
                TipoTecla = "Otras";
            }
        }

        
        // Restablece todas las propiedades estadísticas del teclado a sus valores iniciales.
        public void Reiniciar()
        {
            UltimaTecla = "Ninguna";
            Codigo = 0;
            Pulsaciones = 0;
            TipoTecla = "Sin Tipo";
            Disponible = true;
        }

        
        // Devuelve un texto formateado con la disponibilidad en tiempo real del periférico. 
        public string ObtenerEstado()
        {
            return Disponible ? "ACTIVO" : "NO DISPONIBLE";
        }
    }
}