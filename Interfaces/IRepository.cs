namespace Projeto_Game_DIO.Interfaces
{
    public interface IRepository<T>
    {
         List<T> Lista();
         T RetornaPorID(int Id);
         void Insere(T entidade);
         void Exclui(int Id);
         void Atualiza(int Id, T entidade);
         int ProximoID();
    }
}