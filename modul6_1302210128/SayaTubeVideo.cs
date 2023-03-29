using System;

public class SayaTubeVideo
{
    private int id;
    private String title;
    private int playcount;

    public SayaTubeVideo(String a)
    {
        Random random = new Random();
        this.id = random.Next(1, 99999);
        this.title = a;
        this.playcount = 0;


    }

    public void IncreasePlayCount(int playcount)
    {
        this.playcount = playcount;
        playcount = playcount + 1;
    }
    public int GetPlayCount()
    {
        return this.playcount;
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("ID" + this.id);
        Console.WriteLine("Title" + this.title);
        Console.WriteLine("Play Count" + playcount);
    }

}
