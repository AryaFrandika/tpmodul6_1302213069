using System;

class SayaTubeVideo
{
    public int id;
    public string title;
    public int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(00000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int n)
    {
        this.playCount += n;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: {0}", this.id);
        Console.WriteLine("JUDUL: {0}", this.title);
        Console.WriteLine("PLAY COUNT: {0}", this.playCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string judul = "Tutorial Design By Contract - Arya Frandika Daulay";
        SayaTubeVideo video = new SayaTubeVideo(judul);
        video.IncreasePlayCount(1);
        video.PrintVideoDetails();
    }
}
