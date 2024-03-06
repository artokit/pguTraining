namespace WebApplication4.Models;

public class Comments
{
    public int id { get; set; }
    public int hookah_id { get; set; }
    public string content { get; set; }

    public int rate
    {
        get => rate;
        set
        {
            if (value >= 1 && value <= 5)
            {
                rate = value;
            }
        }
    }
}