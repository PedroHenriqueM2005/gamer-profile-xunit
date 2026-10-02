namespace GamerProfile.App;

public class PerfilJogadorService
{
    /// <summary>
    /// Gera uma tag de usuário concatenando nickname e código com '#'.
    /// </summary>
    public string GerarTagUsuario(string nickname, string codigo)
    {
        return $"{nickname}#{codigo}";
    }

    /// <summary>
    /// Calcula o XP total somando duas fases e aplicando um bônus fixo de 100 pontos.
    /// </summary>
    public int CalcularXPTotal(int xpFase1, int xpFase2)
    {
        return xpFase1 + xpFase2 + 100;
    }

    /// <summary>
    /// Verifica se o jogador é elegível para partidas ranqueadas (nível >= 15).
    /// </summary>
    public bool EEligivelParaRanked(int nivelJogador)
    {
        return nivelJogador >= 15;
    }
}