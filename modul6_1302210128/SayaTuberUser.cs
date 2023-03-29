using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public String title;

    public SayaTubeUser(String judul)
    {
        Random random = new Random();
        this.id = random.Next(1, 99999);
        Debug.Assert(judul != null);
        Debug.Assert(judul.Length < 200);
        this.title = judul;

        uploadedVideos = new List<SayaTubeVideo>();


        /*list kosong;*/
        if (judul == null)
        {
            
        }
        if (judul.Length > 200)
        {
            Console.Error.WriteLine("tidak boleh lebih dar");
        }
    }

    public int GetTotalVideoCount()
    {
        return uploadedVideos.Count;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null);
        Debug.Assert(video.GetPlayCount() < 100000000000);


        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User : ");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("video : " + (i+1) + uploadedVideos[i].GetPlayCount );
            
        }
    }
}
