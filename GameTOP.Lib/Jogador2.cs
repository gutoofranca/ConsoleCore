using GameTOP.Interface;

namespace GameTOP.Lib
{
  public class Jogador2 : iJogador
  {
    public string Chuta()
    {
      return "Fulano está chutando \n";
    }

    public string Corre()
    {
      return "Fulano está correndo \n";
    }

    public string Passe()
    {
      return "Fulano está passando \n";
    }
  }
}