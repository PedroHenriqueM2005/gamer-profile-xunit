using Xunit;
using GamerProfile.App;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    private readonly PerfilJogadorService _service;

    public PerfilJogadorServiceTests()
    {
        _service = new PerfilJogadorService();
    }

    [Fact]
    public void GerarTagUsuario_DeveRetornarFormatoCorreto()
    {
        // Arrange
        string nickname = "Aragorn";
        string codigo = "1042";
        string esperado = "Aragorn#1042";

        // Act
        string resultado = _service.GerarTagUsuario(nickname, codigo);

        // Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void CalcularXPTotal_DeveSomarXPEAplicarBonusCorretamente()
    {
        // Arrange
        int xpFase1 = 200;
        int xpFase2 = 300;
        int esperado = 600;

        // Act
        int resultado = _service.CalcularXPTotal(xpFase1, xpFase2);

        // Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveRetornarTrueOuFalseConformeNivel()
    {
        // Arrange
        int nivelElegivel = 15;
        int nivelNaoElegivel = 14;

        // Act & Assert
        Assert.True(_service.EEligivelParaRanked(nivelElegivel), "Jogador nível 15 deve ser elegível.");
        Assert.False(_service.EEligivelParaRanked(nivelNaoElegivel), "Jogador nível 14 não deve ser elegível.");
    }
}