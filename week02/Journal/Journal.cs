using System;

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added to the journal.\n");
    }

    // Display all entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.\n");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
        // Save entries to a file
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine("Date|Prompt|Response");
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal saved to {file}.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }
        // Load entries from a file
    public void LoadFromFile(string file)
    {
        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string header = reader.ReadLine(); // Skip the header
                _entries.Clear();
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split('|');
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry
                        {
                            _date = parts[0],
                            _promptText = parts[1],
                            _entryText = parts[2]
                        });
                    }
                }
            }
            Console.WriteLine($"Journal loaded from {file}.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}\n");
        }
    }
}
