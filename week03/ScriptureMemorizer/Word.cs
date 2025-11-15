using System.Diagnostics;

public class Word
{
    private string _text;
    private bool _isHidden;
    private string _newword;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        foreach (char letter in _text)
        {
            _newword += "_";
        }
        _isHidden = true;
        _text = _newword;
        
    }
    public void Show()
    {
        _newword = _text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}