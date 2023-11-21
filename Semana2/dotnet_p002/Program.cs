class Program
{
    static void Main()
    {
        // Lista para armazenar as tarefas
        List<Task> tasks = new List<Task>();

        while (true)
        {
            Console.WriteLine("===== Sistema de Gerenciamento de Tarefas =====");
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Todas as Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Listar Tarefas Pendentes");
            Console.WriteLine("5. Listar Tarefas Concluídas");
            Console.WriteLine("6. Excluir Tarefa");
            Console.WriteLine("7. Pesquisar Tarefas por Palavra-chave");
            Console.WriteLine("8. Exibir Estatísticas");
            Console.WriteLine("9. Sair");

            Console.Write("Escolha uma opção: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateTask(tasks);
                    break;
                case 2:
                    ListAllTasks(tasks);
                    break;
                case 3:
                    MarkTaskAsCompleted(tasks);
                    break;
                case 4:
                    ListPendingTasks(tasks);
                    break;
                case 5:
                    ListCompletedTasks(tasks);
                    break;
                case 6:
                    DeleteTask(tasks);
                    break;
                case 7:
                    SearchTasksByKeyword(tasks);
                    break;
                case 8:
                    DisplayStatistics(tasks);
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CreateTask(List<Task> tasks)
    {
        Console.Write("Digite o título da tarefa: ");
        string title = Console.ReadLine();

        Console.Write("Digite a descrição da tarefa: ");
        string description = Console.ReadLine();

        Console.Write("Digite a data de vencimento (formato YYYY-MM-DD): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        Task newTask = new Task(title, description, dueDate);
        tasks.Add(newTask);

        Console.WriteLine("Tarefa criada com sucesso!");
    }

    static void ListAllTasks(List<Task> tasks)
    {
        Console.WriteLine("===== Lista de Todas as Tarefas =====");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    static void MarkTaskAsCompleted(List<Task> tasks)
    {
        Console.Write("Digite o título da tarefa concluída: ");
        string title = Console.ReadLine();

        Task task = tasks.Find(t => t.Title == title);

        if (task != null)
        {
            task.Completed = true;
            Console.WriteLine("Tarefa marcada como concluída!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    static void ListPendingTasks(List<Task> tasks)
    {
        var pendingTasks = tasks.Where(t => !t.Completed).ToList();
        Console.WriteLine("===== Lista de Tarefas Pendentes =====");
        foreach (var task in pendingTasks)
        {
            Console.WriteLine(task);
        }
    }

    static void ListCompletedTasks(List<Task> tasks)
    {
        var completedTasks = tasks.Where(t => t.Completed).ToList();
        Console.WriteLine("===== Lista de Tarefas Concluídas =====");
        foreach (var task in completedTasks)
        {
            Console.WriteLine(task);
        }
    }

    static void DeleteTask(List<Task> tasks)
    {
        Console.Write("Digite o título da tarefa a ser excluída: ");
        string title = Console.ReadLine();

        Task task = tasks.Find(t => t.Title == title);

        if (task != null)
        {
            tasks.Remove(task);
            Console.WriteLine("Tarefa excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    static void SearchTasksByKeyword(List<Task> tasks)
    {
        Console.Write("Digite a palavra-chave para pesquisa: ");
        string keyword = Console.ReadLine();

        var resultTasks = tasks.Where(t => t.Title.Contains(keyword) || t.Description.Contains(keyword)).ToList();

        Console.WriteLine("===== Resultado da Pesquisa =====");
        foreach (var task in resultTasks)
        {
            Console.WriteLine(task);
        }
    }

    static void DisplayStatistics(List<Task> tasks)
    {
        int totalTasks = tasks.Count;
        int completedTasks = tasks.Count(t => t.Completed);
        int pendingTasks = totalTasks - completedTasks;

        Task oldestTask = tasks.OrderBy(t => t.DueDate).FirstOrDefault();
        Task newestTask = tasks.OrderByDescending(t => t.DueDate).FirstOrDefault();

        Console.WriteLine($"Total de tarefas: {totalTasks}");
        Console.WriteLine($"Tarefas concluídas: {completedTasks}");
        Console.WriteLine($"Tarefas pendentes: {pendingTasks}");
        Console.WriteLine($"Tarefa mais antiga: {oldestTask?.Title} (Vencimento: {oldestTask?.DueDate})");
        Console.WriteLine($"Tarefa mais recente: {newestTask?.Title} (Vencimento: {newestTask?.DueDate})");
    }
}

class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool Completed { get; set; }

    public Task(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        Completed = false;
    }

    public override string ToString()
    {
        string status = Completed ? "Concluída" : "Pendente";
        return $"Título: {Title}, Descrição: {Description}, Vencimento: {DueDate}, Status: {status}";
    }
}
