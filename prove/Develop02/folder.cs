using System;


public class File
{
    public string _fileName;

    List<File>_files = new List<File>();

    public void AddFile(File file)// adding file to files
    {
        _files.Add(file);
    }
    
    public void Display()
    {
   
    }

}