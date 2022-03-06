namespace Projeto_Game_DIO
{
    class Program
    {
        static GameRepositorio repositorio = new GameRepositorio();
        static void Main(string[] args)
        {
            string userOption = ObterOpcaoUsuario();
            while (userOption.ToUpper() != "E")
            {
                if(userOption == "1" || userOption == "2" || userOption == "3" || userOption == "4" || userOption == "5")
                {
                    switch (userOption)
                    {
                        case ("1"):
                            Console.Clear();
                            ListarGames();
                            Console.Clear();
                            break;
                        case ("2"):
                            Console.Clear();
                            InserirGame();
                            break;
                        case ("3"):
                            Console.Clear();
                            ListarGames();
                            AtualizarGame();
                            break;
                        case ("4"):
                            Console.Clear();
                            ListarGames();
                            ExcluirGame();
                            break;
                        case ("5"):
                            Console.Clear();
                            ListarGames();
                            VisualizarGame();
                            break;
                    }
                }else
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido, insira novamente");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione QUALQUER tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                }
                userOption = ObterOpcaoUsuario();
            }
            Console.Clear();
            Console.WriteLine("Volte Sempre");
            Console.WriteLine("");
            Console.WriteLine("Pressione QUALQUER tecla para continuar...");
            Console.ReadKey();
        }
        private static void ListarGames()
        {
            Console.WriteLine("");
            Console.WriteLine("Listar Games");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");


            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Nenhum Game Cadastrado");
                Console.WriteLine("");
                Console.WriteLine("Pressione QUALQUER tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            foreach (var game in lista)
            {
                var excluido = game.retornaExcluido();
                Console.WriteLine($"#ID {game.retornaId()} - {game.retornaTitulo()} {(excluido ? " - Excluido" : "")}");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione QUALQUER tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        private static void InserirGame()
        {
            Console.WriteLine("");
            Console.WriteLine("Inserir novo Game");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o GÊNERO entre as opções acima:");
            int entradagenero = int.Parse(Console.ReadLine());
            Console.Clear();

            foreach (int i in Enum.GetValues(typeof(SubGenero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(SubGenero), i)}");
            }
            Console.WriteLine("Digite o SUB-GÊNERO entre as opções acima:");
            int entradasubgenero = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o TÍTULO do game:");
            string entradatitulo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o DESCRIÇÃO do game:");
            string entradadescricao = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o NOME DA DESENVOLVEDORA do game:");
            string entradadesenvolvedora = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o ANO DE LANÇAMENTO do game:");
            int entradaano = int.Parse(Console.ReadLine());
            Console.Clear();

            Game novoGame = new Game(id: repositorio.ProximoID(),
            genero: (Genero)entradagenero,
            subGenero: (SubGenero)entradasubgenero,
            titulo: entradatitulo,
            descricao: entradadescricao,
            desenvolvedora: entradadesenvolvedora,
            ano: entradaano
            );
            repositorio.Insere(novoGame);
        }
        private static void AtualizarGame()
        {
            Console.WriteLine("");
            Console.WriteLine("Atualizar Game");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");


            Console.WriteLine("Digite o ID do Game:");
            int indiceGame = int.Parse(Console.ReadLine());
            Console.Clear();

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o GÊNERO entre as opções acima:");
            int entradagenero = int.Parse(Console.ReadLine());
            Console.Clear();

            foreach (int i in Enum.GetValues(typeof(SubGenero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(SubGenero), i)}");
            }
            Console.WriteLine("Digite o SUB-GÊNERO entre as opções acima:");
            int entradasubgenero = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o TÍTULO do game:");
            string entradatitulo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o DESCRIÇÃO do game:");
            string entradadescricao = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o NOME DA DESENVOLVEDORA do game:");
            string entradadesenvolvedora = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o ANO DE LANÇAMENTO do game:");
            int entradaano = int.Parse(Console.ReadLine());
            Console.Clear();

            Game atualizarGame = new Game(id: indiceGame,
            genero: (Genero)entradagenero,
            subGenero: (SubGenero)entradasubgenero,
            titulo: entradatitulo,
            descricao: entradadescricao,
            desenvolvedora: entradadesenvolvedora,
            ano: entradaano
            );
            repositorio.Atualiza(indiceGame, atualizarGame);
        }
        private static void ExcluirGame()
        {
            Console.WriteLine("");
            Console.WriteLine("Excluir Game");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");


            Console.WriteLine("Digite o ID do Game:");
            int indiceGame = int.Parse(Console.ReadLine());
            Confirmar(indiceGame); 

        }
        private static void VisualizarGame()
        {
            Console.WriteLine("");
            Console.WriteLine("Visualizar Game");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");


            Console.WriteLine("Digite o ID do Game:");
            int indiceGame = int.Parse(Console.ReadLine());

            var game = repositorio.RetornaPorID(indiceGame);
            Console.WriteLine(game);
            Console.WriteLine("Pressione QUALQUER tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        private static void Confirmar(int indiceGame){
            Console.WriteLine("Deseja mesmo EXCLUIR o game?");
            Console.WriteLine("");
            Console.WriteLine("Pressine Y para confirmar");
            string confirmacao = Console.ReadLine().ToUpper();
            if(confirmacao.ToUpper() == "Y"){
                repositorio.Exclui(indiceGame);
                Console.Clear();
            }else{
                Console.Clear();
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("");
            Console.WriteLine("Bem-Vindo na GameFlix");
            Console.WriteLine("O seu Canal de Games");
            Console.WriteLine("");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar Games");
            Console.WriteLine("2- Adicionar Game");
            Console.WriteLine("3- Atualizar Game");
            Console.WriteLine("4- Excluir Game");
            Console.WriteLine("5- Visualizar Game");
            Console.WriteLine("E- Sair");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("");

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}