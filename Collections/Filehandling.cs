class Files
{
    public void Filehandling()
    {
        string path = "myFile.txt";
        FileStream fs = File.Create(path);
        if (File.Exists(path))
        {
            Console.WriteLine("done");

        }
        else
        {
            Console.WriteLine("you fucked up");
        }


    }
}