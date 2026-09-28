class Program
{
    static List<String> alunos = new List<String>();
    static List<double[]> notas = new List<double[]>();

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

            switch (intOpcao)
            {
                case 1: CadastrarAluno(); break;
                case 2: LancarNotas(); break;
                case 3: CalcularMedia(); break;
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

            if (string.IsNullOrEmpty(aluno))
            {
                break;
            }

            if (int.TryParse(aluno, out int intAlunoTeste))
            {
                Console.WriteLine($"Entrada ``{aluno}`` inválida. Por favor, digite um nome válido.\n");
                continue;
            }

            alunos.Add(aluno);
            notas.Add(new double[] {-1 , -1, -1});
            Console.WriteLine($"Aluno '{aluno}' cadastrado com sucesso!\n");
        }
    }

    private static void LancarNotas()
    {
        Console.WriteLine("\n__LANÇAR NOTAS__\n");

        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado no sistema ainda.\n");
            return;
        }

        while (true)
        {
            Console.WriteLine("Lista de Alunos:");
            int j = 0;
            foreach (string aluno in alunos)
            {
                Console.WriteLine($"ID: {j} | Nome: {aluno}");
                j++;
            }

            Console.WriteLine("\nDigite o ID do aluno para lançar as notas (ou aperte Enter para voltar):");
            string? inputId = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputId))
            {
                break;
            }

            if (!int.TryParse(inputId, out int index) || index < 0 || index >= alunos.Count)
            {
                Console.WriteLine($"\nID '{inputId}' inválido ou aluno não encontrado. Olhe para a lista e tente de novo.\n");
                continue;
            }

            double[] notasAtuais = new double[3];

            Console.WriteLine($"\nLançando notas para: {alunos[index]}");
            for (int i = 0; i < 3; i++)
            {
                double notaValida;
                while (true)
                {
                    Console.Write($"Atribua a nota ao aluno\n- Digite a {i + 1}ª nota (de 0 a 10): ");
                    string? strNota = Console.ReadLine();

                    if (double.TryParse(strNota, out notaValida) && notaValida >= 0 && notaValida <= 10)
                    {
                        break;
                    }
                    Console.WriteLine($"Valor de nota ({strNota}) inválido! Digite um número entre 0 e 10");
                }

                notasAtuais[i] = notaValida;
            }

            notas[index] = notasAtuais;

            Console.WriteLine($"\nNotas lançadas com sucesso para o aluno '{alunos[index]}'!!");

            break;
        }
    }

    private static void CalcularMedia()
    {
        Console.WriteLine("\n__CALCULAR MÉDIA__\n");

        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado no sistema ainda.\n");
            return;
        }

        while (true)
        {
            Console.WriteLine("Lista de Alunos:");
            int j = 0;
            foreach (string aluno in alunos)
            {
                Console.WriteLine($"ID: {j} | Nome: {aluno}");
                j++;
            }

            Console.WriteLine("\nDigite o NOME do aluno para calcular a média (ou aperte Enter para voltar):");
            string? nomeBusca = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeBusca))
            {
                break;
            }

            int index = alunos.FindIndex(a => a.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));

            if (index == -1)
            {
                Console.WriteLine($"\nAluno '{nomeBusca}' não encontrado.\n");
                continue;
            }

            if (notas[index][0] == -1)
            {
                Console.WriteLine($"\nO aluno '{alunos[index]}' ainda não possui notas cadastradas. Cadastre na opção de número 2\n");
                continue;
            }

            double soma = 0;


            for (int i = 0; i < 3; i++)
            {
                soma += notas[index][i];
            }

            double media = Math.Round(soma / 3, 2);

            Console.WriteLine($"\nAluno: {alunos[index]}");
            Console.WriteLine($"Média: {media}");

            ExibirSituacao(media);
            break;
        }
    }

    private static void ExibirSituacao(double media)
    {
        if (media >= 7.0)
        {
            Console.WriteLine("Situação: Aprovado\n");
        }
        else if (media >= 5.0)
        {
            Console.WriteLine("Situação: Recuperação\n");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado\n");
        }
    }
}