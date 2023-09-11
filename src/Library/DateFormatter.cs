namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
    if (IsValidDateFormat(date))
    {
        string[] parts = date.Split('/');
        if (parts.Length == 3)
        {
            int day = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int year = int.Parse(parts[2]);

            return $"{year:D4}-{month:D2}-{day:D2}";
        }
    }

    return string.Empty;
    }

    private static bool IsValidDateFormat(string date)
    {
        if (date.Length != 10)
        {
            return false;
        }

        string[] parts = date.Split('/');
        if (parts.Length != 3)
        {
            return false;
        }

        if (!int.TryParse(parts[0], out int day) || !int.TryParse(parts[1], out int month) || !int.TryParse(parts[2], out int year))
        {
            return false;
        }

        return day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1;
    }
}
