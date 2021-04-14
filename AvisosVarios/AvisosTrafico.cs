using System;

namespace AvisosVarios
{
    public class AvisosTrafico : IAvisos
    {
        private String Remitente;
        private String Mensaje;
        private String Fecha;

        public AvisosTrafico()
        {
            Remitente = "Vialidad y Transito";

            Mensaje = @"Sanción cometida. Pague antes de 3 días y se beneficiará de una reducción 
            en la sanción del 50%.";

            Fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            Remitente = remitente;

            Mensaje = mensaje;

            Fecha = fecha;
        }

        public string GetFecha()
        {
            return Fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine($"Mensaje: {Mensaje} ha sido enviado por: {Remitente} el día {Fecha}.");
        }
    }
}