public class Scripture
{
    public Reference _reference;
   private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] wordsArray = text.Split(" ");
        foreach (string w in wordsArray)
        {
            _words.Add(new Word(w));
        }
    }
     
    public void HideRandomWords(int numbersToHide)
{
    int hiddennum = 0;
    Random random = new Random();

    int visibleWords = _words.Count(w => !w.IsHidden());
    int wordsToHide = Math.Min(numbersToHide, visibleWords);

    while (hiddennum < wordsToHide)
    {
       
        int words_index = random.Next(_words.Count);

        if (!_words[words_index].IsHidden())
        {
            _words[words_index].Hide();
            hiddennum++;
        }
        
    }
}



    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";

        foreach (Word w in _words)
        {
             display += w.GetDisplayText() + " ";
             
        }
        
        return  display.Trim();
        
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


}