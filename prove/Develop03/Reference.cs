using System; 

public class Reference
{
    private string _reference;

    public string GetText()
    {
        return _reference;
    }
    public Reference(string text)
    {
        _reference = text;
    }
}