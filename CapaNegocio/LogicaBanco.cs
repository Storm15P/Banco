namespace CapaNegocio
{
    public class LogicaBanco
    {
        private readonly FuenteDatos accesoDatos;

        public LogicaBanco(FuenteDatos fuenteDatos)
        {
            accesoDatos = fuenteDatos;
        }

        public string EvaluarCredito(
            decimal monto,
            int plazo,
            decimal ingresos,
            decimal egresos,
            int nroDoc)
        {
            // Validar plazo
            if (plazo < 1 || plazo > 72)
                return "Plazo inválido. Debe ser entre 1-72 meses";

            // Calcular balanza
            decimal balanza = ingresos - egresos;
            if (balanza <= 0)
                return "Balanza negativa o cero. Crédito denegado";

            // Calcular relación
            decimal relacion = (monto / plazo) / balanza;

            // Obtener puntaje
            var riesgo = accesoDatos.ConsultarRiesgo(nroDoc);
            if (!int.TryParse(riesgo.Puntaje, out int puntaje))
                return "Error obteniendo puntaje de riesgo";

            // Evaluar reglas
            if (relacion >= 0.95M)
                return "Relación crédito/balanza demasiado alta. Denegado";

            if (relacion >= 0.7M)
                return puntaje >= 800 ? "Aprobado" : "Puntaje insuficiente (<800)";

            if (relacion >= 0.4M)
                return puntaje >= 600 ? "Aprobado" : "Puntaje insuficiente (<600)";

            return puntaje >= 400 ? "Aprobado" : "Puntaje insuficiente (<400)";
        }
    }
}