using System.ComponentModel.Design;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    public string _filename;
    public List<Entry> listEntries = new List<Entry>();
    
    public void addinfo(Entry entry)
    {
        listEntries.Add(entry);

    }
    public void Display()
    {
        for (int numbersToDisplay = 0; numbersToDisplay < listEntries.Count; numbersToDisplay++)
        {
            Console.WriteLine($"Entry #{numbersToDisplay + 1}.\nDate: {listEntries[numbersToDisplay]._todayDate} - Prompt: {listEntries[numbersToDisplay]._prompt}\n{listEntries[numbersToDisplay]._getNote}\n");
        }

    }
   

    
}

