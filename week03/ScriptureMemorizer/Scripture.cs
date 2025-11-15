public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string w in words)
        {
            Word word = new Word(w);
            _words.Add(word);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i <= numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
                _words[index].Hide();
            else
            {
                i--;
            }
        }
    }

    public string GetDisplayText()
    {
        IEnumerable<string> text = _words.Select(obj => obj.GetDisplayText());
        string scripture = string.Join("  ", text);
        return $"{_reference.GetDisplayText()} {scripture}";
    }

    public bool isCompleteHidden()
    {
        bool allAreHidden = _words.All(item => item.IsHidden());
        return allAreHidden;
       
    }
}