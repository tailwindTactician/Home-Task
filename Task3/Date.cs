public class Date
{
    private int day;
    private int month;
    private int year;
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public void SetDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public int GetYear()
    {
        return year;
    }
    public int GetMonth()
    {
        return month;
    }
    public int GetDay()
    {
        return day;
    }
    public string ToString()
    {
        return $"{day:D2}/{month:D2}/{year}";
    }
}