using System;

class SayaTubeVideo
{
    public int id;
    public string title;
    public int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
        {
            throw new ArgumentException("Judul tidak valid");
        }

        Random random = new Random();
        this.id = random.Next(00000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int n)
    {
        if (n > 10000000)
        {
            throw new ArgumentException("Jumlah play count terlalu besar");
        }

        try
        {
            checked
            {
                this.playCount += n;
            }
        }
        catch (OverflowException)
        {
            throw new OverflowException("Melebihi batas maksimum");
        }
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
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Arya Frandika Daulay");
        video.IncreasePlayCount(10000000);
        video.PrintVideoDetails();

        try
        {
            SayaTubeVideo kosong = new SayaTubeVideo(null);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            string title = new string("juduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljuduljudul");
            SayaTubeVideo judul = new SayaTubeVideo(title);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            for (int i = 0; i < 100000; i++)
            {
                video.IncreasePlayCount(1000000);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
