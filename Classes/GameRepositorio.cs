using Projeto_Game_DIO.Interfaces;

namespace Projeto_Game_DIO
{
    public class GameRepositorio : IRepository<Game>
    {
        private List<Game> listagame = new List<Game>();
        public void Atualiza(int Id, Game entidade)
        {
            listagame[Id] = entidade;
        }

        public void Exclui(int Id)
        {
            listagame[Id].Excluir();
        }

        public void Insere(Game entidade)
        {
            listagame.Add(entidade);
        }

        public List<Game> Lista()
        {
            return listagame;
        }

        public int ProximoID()
        {
            return listagame.Count;
        }

        public Game RetornaPorID(int Id)
        {
            return listagame[Id];
        }
    }
}