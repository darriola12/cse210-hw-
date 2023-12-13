using System;
using System.Data;


public class Video
{
    public string _title; 
    public string _author; 
    public int _lenght; 

    List<Comment> comments; 

    public  Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght; 
        comments = new List<Comment>();
    }

    public void addcomment(string name, string text)
    {
        Comment comment = new  Comment(name, text);
        comments.Add(comment);

    }
    public int countComment() 
    {
        return comments.Count;
    }

    public  List<Comment> getcomment()
    {
        return comments;

    }  

}