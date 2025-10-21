// See https://aka.ms/new-console-template for more information

using SistemaBiblioteca;
using System.Globalization;

List<Book> books = new List<Book> ();
int opMenu;

string filePath = "biblioteca.txt";
string directoryPath = @"C:\Arquivos";
var fullPath = Path.Combine(directoryPath, filePath);

int ShowMainMenu()
{
    Console.WriteLine ("=== CADASTRO DE LIVROS ===");
    Console.WriteLine("1 - Adicionar Livro");
    Console.WriteLine("2 - Listar Livros");
    Console.WriteLine("3 - Editar Livro");
    Console.WriteLine("4 - Deletar Livro");
    Console.WriteLine("5 - Salvar e sair");
    Console.Write("\nInforme a opção desejada: ");
    return Convert.ToInt32(Console.ReadLine());
}

void AddBook()
{
    Console.WriteLine("=== ADICIONAR LIVRO ===\n");
    Console.Write("Informe o título do livro: ");
    string title = Console.ReadLine()!;
    Console.Write("Informe o autor do livro: ");
    string author = Console.ReadLine()!;
    Console.Write("Informe a categoria do livro: ");
    string category = Console.ReadLine()!;
    
    books.Add(new Book(title,author,category));

    Console.Clear();
}

void ListAllBooks()
{
    
    Console.WriteLine("=== LISTA DE LIVROS ===\n\nFormato: Título|Autor|Categoria\n");

    if (books.Count == 0)
    {
        Console.WriteLine("Nenhum livro cadastrado.");
    }
    else
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book + "\n");
        }
    }
    Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal.");
    Console.ReadKey();
    Console.Clear();
}

Book? SearchBook(string title)
{
   return books.Find(b => b.GetTitle() == title);
}

void UpdateTitleBook()
{
    Console.WriteLine("=== ATUALIZAR LIVRO ===\n");
    Console.Write("Informe o título do livro que deseja alterar: ");
    var book = SearchBook(Console.ReadLine()!);

    if (book is not null)
    {
        Console.Write("Informe o título correto: ");
        string title = Console.ReadLine()!;
        book.SetTitle(title);
    }
    else
    {
        Console.WriteLine("LIVRO NÃO ENCONTRADO!\n");
    }
    Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal.");
    Console.ReadKey();
    Console.Clear();
}

void DeleteBook()
{
    Console.WriteLine("=== EXCLUIR LIVRO ===\n");
    Console.Write("Informe o título do livro que deseja excluir: ");
    var book = SearchBook(Console.ReadLine()!);

    if (book is not null)
    {
        books.Remove(book);
    }
    else
    {
        Console.WriteLine("LIVRO NÃO ENCONTRADO!\n");
    }
    Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal.");
    Console.ReadKey();
    Console.Clear();
}

void SaveAndLeave()
{
    StreamWriter writer = new StreamWriter(fullPath, append: true);

    using (writer)
    {
        foreach (var book in books)
        {
            writer.WriteLine(book);
        }
        writer.Close();
    }

}



try
{
    if (!Directory.Exists(directoryPath))
    {
        Directory.CreateDirectory(directoryPath);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.StackTrace);
    Console.WriteLine(e.Message);
}


do
{
    opMenu = ShowMainMenu();
    Console.Clear();

    switch (opMenu)
    {
        case 1:
            AddBook();
            break;
        case 2:
            ListAllBooks();
            break;
        case 3:
            UpdateTitleBook();
            break;
        case 4:
            DeleteBook();
            break;
        case 5:
            SaveAndLeave();
            break;
        default:
            Console.WriteLine("Informe uma opção válida!");
            break;
    }

} while (opMenu != 5);
