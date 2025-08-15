public class Book
{
    private string title { get; set; }
    private string author { get; set; }
    private int year { get; set; }

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    public string GetInfo()
    {
        return $"Title: {title}, Author: {author}, Year: {year}";
    }

    public bool IsPublishedRecently()
    {
        return year > 2010;
    }
}

