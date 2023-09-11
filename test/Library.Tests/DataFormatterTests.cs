using TestDateFormat;

namespace TestDateFormat.Tests;

/// <summary>
/// Tests para la clase <see cref="DateFormatter"/>.
/// </summary>
public class DateFormatterTests
{
    /// <summary>
    /// Prueba el método <see cref="DateFormatter.ChangeFormat"/>.
    /// </summary>
    [Test]
    public void TestChangeFormat_CorrectFormat()
    {
        string fecha1 = "22/05/2022";
        string expectedFormattedDate = "2022-05-22";
        Assert.AreEqual(expectedFormattedDate, DateFormatter.ChangeFormat(fecha1));
    }

    [Test]
    public void TestChangeFormat_WrongFormat()
    {
        string fecha3 = "05-22-2022"; // Formato incorrecto
        Assert.AreEqual(string.Empty, DateFormatter.ChangeFormat(fecha3));
    }

    [Test]
    public void TestChangeFormat_EmptyDate()
    {
        string fecha4 = ""; // Fecha en blanco
        Assert.AreEqual(string.Empty, DateFormatter.ChangeFormat(fecha4));
    }
}