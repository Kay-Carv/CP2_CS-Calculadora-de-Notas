class Program
{
    static List<String> alunos = new List<String>();


    static void Main()
    {
        string? strOpcao;   
        do
        {
            Console.WriteLine("\n===\tDigite uma opção de (1 a 3) ou digite (4) para sair:\t===");
            Console.WriteLine("\n1 - Cadastrar aluno \n2 - Lançar notas \n3 - Calcular média \n4 - Sair\n");
            strOpcao = Console.ReadLine();
            if (!int.TryParse(strOpcao, out int intOpcao) || intOpcao <= 0 || intOpcao > 4)
            {
                Console.WriteLine($"Entrada ``{strOpcao}`` inválida, escreva uma opção númerica de 1 a 4");
                continue;
            }
            
            switch (intOpcao) {
                case 1: CadastrarAluno(); break;
                case 2: break;
                case 3: break;
                case 4: Console.WriteLine("\nEncerrando o sistema . . ."); return;
            }

        } while (true);
    }

    private static void CadastrarAluno()
    {
        Console.WriteLine("\n__CADASTRO DE ALUNO__\n");

        while (true)
        {
            Console.WriteLine("Digite o nome do aluno a ser cadastrado (ou aperte Enter sem digitar nada para voltar ao menu):");
            string? aluno = Console.ReadLine();

            if (string.IsNullOrEmpty(aluno)) {
                break;
            }

            if (int.TryParse(aluno, out int intAlunoTeste))
            {
                Console.WriteLine($"Entrada ``{aluno}`` inválida. Por favor, digite um nome válido.\n");
                continue;
            }

            alunos.Add(aluno);
            Console.WriteLine($"Aluno '{aluno}' cadastrado com sucesso!\n");
        }
    }
}