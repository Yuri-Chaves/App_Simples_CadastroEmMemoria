namespace Projeto_Game_DIO
{
    public class Game : BaseEntity
    {
        public Game(int id, Genero genero, SubGenero subGenero, string titulo, string descricao, string desenvolvedora, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.SubGenero = subGenero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Desenvolvedora = desenvolvedora;
            this.Ano = ano;
            this.Excluido = false;
        }

        private Genero Genero{ get; set; }
        private SubGenero SubGenero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private string Desenvolvedora { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Sub-Gênero: " + this.SubGenero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Desenvolvedora: " + this.Desenvolvedora + Environment.NewLine;
            retorno += "Ano de Desenvolvimento: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;

        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaId(){
            return this.Id;
        }
        public bool retornaExcluido(){
            return this.Excluido;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }
}