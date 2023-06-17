Book book1 = new Book("Harry Potter and the Sorcerer's Stone", "J. K. Rowling");

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void PrintSummary()
    {
        string summary = $"{Title} - {Author}";
        Console.WriteLine(summary);
    }

    public int GetTitleLenghtWithoutWhiteSpaces()
    {
        string titleWithoutWhiteSpaces = Title.Replace(" ", "");
        return titleWithoutWhiteSpaces.Length;
    }
}