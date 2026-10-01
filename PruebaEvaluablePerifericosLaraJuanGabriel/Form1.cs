using System;
using System.Drawing;
using System.Windows.Forms;

namespace PruebaEvaluablePerifericosLaraJuanGabriel
{
    // Capa de presentación (UI). Gestiona la captura de eventos hardware de Windows 
    // y delega el procesamiento lógico a las clases controladoras.
    public partial class Form1 : Form
    {
        // Instancias privadas de las clases lógicas independientes
        private readonly TecladoControlador teclado;
        private readonly RatonControlador raton;

        public Form1()
        {
            InitializeComponent();

            // Instanciación de los objetos de control
            teclado = new TecladoControlador();
            raton = new RatonControlador();

            // Habilita que el Form intercepte las teclas antes que los controles secundarios
            KeyPreview = true;

            // Enlace directo de los manejadores de eventos nativos
            KeyDown += Form1_KeyDown;
            MouseMove += Form1_MouseMove;
            MouseClick += Form1_MouseClick;
        }

        // Captura la pulsación de teclas a nivel de formulario.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            teclado.ProcesarTecla(e.KeyCode); // Pasa la información técnica al controlador
            ActualizarInterfaz();             // Sincroniza la UI
        }

        
        // Detecta cada movimiento del cursor del ratón sobre la ventana.
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            raton.ProcesarMovimiento(e.Location); // Envía las coordenadas actuales
            ActualizarInterfaz();
        }

        
        // Captura las pulsaciones de los botones del ratón.
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            raton.ProcesarClic(e.Button); // Identifica si es clic izquierdo o derecho
            ActualizarInterfaz();
        }

        
        // Método unificado centralizado para refrescar los Labels de la pantalla.
        // Evita la duplicidad innecesaria de cadenas de texto y simplifica la vista.
        private void ActualizarInterfaz()
        {
            // Bloque de renderizado de información del Ratón
            lblUltimoBotonRaton.Text = $"Último botón: {raton.UltimoBoton}";
            lblPosicionX.Text = $"Posición X: {raton.PosicionX}";
            lblPosicionY.Text = $"Posición Y: {raton.PosicionY}";
            lblClics.Text = $"Clics: {raton.Clics}";

            // Bloque de renderizado de información del Teclado
            lblUltimaTecla.Text = $"Última tecla: {teclado.UltimaTecla}";
            lblCodigoTecla.Text = $"Código: {teclado.Codigo}";
            lblTipo.Text = $"Tipo: {teclado.TipoTecla}";

            // Bloque de renderizado de estados de hardware (Corregido texto duplicado)
            lblRatonActivo.Text = $"Ratón estado: {raton.ObtenerEstado()}";
            lblTecladoActivo.Text = $"Teclado estado: {teclado.ObtenerEstado()}";
        }


        // Manejador de evento del botón de reinicio de estadísticas.
        private void btnReiniciarInterfaz_Click(object sender, EventArgs e)
        {
            // Aplica el reinicio lógico directamente sobre los objetos controladores
            teclado.Reiniciar();
            raton.Reiniciar();

            // Redibuja la interfaz limpia leyendo el estado a cero de los objetos
            ActualizarInterfaz();
        }
    }
}