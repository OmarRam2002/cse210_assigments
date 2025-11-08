using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}");
            }
        }

    }
    public void LoadFromFile(string file)
    {
        string [] lines = System.IO.File.ReadAllLines(file);
        _entries.Clear();
        string datePart = "";
        string promptPart = "";
        string entryText = "";

        int i = 0;
        foreach (string line in lines)
        {
            i++;

            if (line.StartsWith("Date: "))
            {
                datePart = line.Substring(6, line.IndexOf(" - Prompt: ") - 6);
                promptPart = line.Substring(line.IndexOf(" - Prompt: ") + 11);
            }
            else
            {
                entryText = line.Trim();
            }
            if (i % 2 == 0)
            {
            
                Entry entry = new Entry();
                entry._date = datePart;
                entry._promptText = promptPart;
                entry._entryText = entryText;
                _entries.Add(entry);
            }

        }

    }

}
