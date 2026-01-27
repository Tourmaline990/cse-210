public class Word
{
    private string _text;
    private bool _ishidden;
    
    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _ishidden = true;
    }
    public  void Show()
    {
        _ishidden = false;
    }
    public  bool IsHidden()
    {
        return _ishidden;
    }
    public string GetDisplayText()
    {
        if (_ishidden)
        {
             string underscore = "";

             for (int i = 0; i < _text.Length; i++)
             {
                underscore += "_";
             }

             return underscore;
        }
        else
        {
            return _text;
        }

    }
}