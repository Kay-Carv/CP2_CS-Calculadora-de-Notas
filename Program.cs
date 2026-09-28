class Program
{


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
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: Console.WriteLine("\nEncerrando o sistema . . ."); return;
            }

        } while (true);
    }


}