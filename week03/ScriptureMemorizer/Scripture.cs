public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(new char[] { ' ', '.', ',', ':'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordCount = 0;

        while (wordCount < numberToHide)
        {
            int randomNumber = rand.Next(_words.Count);
            Word word = _words[randomNumber];

            if (word.IsHidden() == false)
            {
                word.Hide();
                wordCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}