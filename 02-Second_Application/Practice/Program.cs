Console.WriteLine("Olá tudo bom? Seja bem vindo 😁");
Console.WriteLine("Precisamos de algumas informações para o seu cadastro.");

Console.Write("Qual é o seu nome? ");
string nome;
nome = Console.ReadLine();
Console.WriteLine("Bem vindo " + nome);

Console.Write("Quantos anos você tem? ");
string idade;
idade = Console.ReadLine();

Console.Write("Qual país você mora? ");
string paisMorar;
paisMorar = Console.ReadLine();

Console.Write("Qual a sua data de nascimento? ");
string dataNascimento;
dataNascimento = Console.ReadLine();

Console.Write("Qual é o seu número de telefone?" );
string numeroDeTelefone;
numeroDeTelefone = Console.ReadLine();

Console.WriteLine("Dados salvos: ");
Console.WriteLine("Nome: " + nome + "," + " Idade: " + idade + "," + " País: " + paisMorar + "," + " Data de nascimento: " + dataNascimento + "," + " Número de telefone: " + numeroDeTelefone);

Console.ReadLine();