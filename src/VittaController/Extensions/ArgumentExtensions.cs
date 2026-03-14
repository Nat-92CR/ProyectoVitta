namespace VittaController.Extensions
{
    /// <summary>
    /// Clase que contiene métodos auxiliares y de extensión para convertir y validar argumentos del sistema.
    /// </summary>
    public static class ArgumentExtensions
    {
        /// <summary>
        /// Convierte el valor de texto recibido en un número entero utilizando un método de extensión.
        /// </summary>
        /// <param name="argument">El argumento en formato de texto.</param>
        /// <returns>El valor del argumento convertido a entero.</returns>
        public static int ToInt(this string argument)
        {
            if (int.TryParse(argument, out var result))
            {
                return result;
            }

            throw new NotSupportedException("The provided argument cannot be converted to an integer.");
        }

        /// <summary>
        /// Convierte el valor de texto recibido en un número entero utilizando un método estático.
        /// </summary>
        /// <param name="argument">El argumento en formato de texto.</param>
        /// <returns>El valor del argumento convertido a entero.</returns>
        public static int ToInteger(string argument)
        {
            if (int.TryParse(argument, out var result))
            {
                return result;
            }

            throw new NotSupportedException("The provided argument cannot be converted to an integer.");
        }
    }
}