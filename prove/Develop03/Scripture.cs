public class Scripture
{
    //attributes or member variables (private)
    private Reference _reference;
    private List<Word> _words;


    //methods and/or constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int n = 0; n < numberToHide; n ++)
        {
            var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
            if (visibleWords.Count == 0) break;
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();

        }
    }

    public string GetDisplayText()
    {
        string refText = (_reference.GetDisplayText());
        Console.WriteLine("\n");
        string scriptText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{refText} {scriptText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }





}