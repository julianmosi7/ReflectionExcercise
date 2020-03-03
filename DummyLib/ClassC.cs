
namespace DummyLib
{
  /// <summary>
  /// Alleinstehende Klasse für DummyLib
  /// </summary>
  public class ClassC
  {
    /// <summary>
    /// Summiert die drei Parameter
    /// </summary>
    /// <param name="valA">Erster Wert</param>
    /// <param name="valB">Zweiter Wert</param>
    /// <param name="valC">Dritter Wert</param>
    /// <returns>Summe der drei Werte</returns>
    public int H(int valA, int valB = 3, int valC = 4) => valA + valB + valC;

    public static int StaticF(int x) => x * -1;

  }
}
