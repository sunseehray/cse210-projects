using System;

public class Scripture
{
    private string _reference;
    private string _content;

    private string[] _words;

    private bool[] _whatIsHidden;

    private string[] _renderedWords;

    // default is single verse
    public Scripture()
    {
        Reference reference = new Reference();
        _reference = reference.GetReference(reference);
        _content = reference.GetScripture(reference);
        CreateArrays(_content);
    }

    // for multiple verse
    public Scripture(int i = 2)
    {
        Reference reference1 = new Reference();
        Reference reference2 = new Reference(2);
        _reference = reference1.GetMultiReference(reference1, reference2);
        _content = reference1.GetMultiScripture(reference1,reference2);
        CreateArrays(_content);
    }

    // constructor?
    public void CreateArrays(string source)
    {
        _words = source.Split();
        int wordCount = _words.Length;
        bool[] whatIsHidden = new bool[wordCount];
        _whatIsHidden = whatIsHidden;
        string[] renderedWords = new string[wordCount];
        _renderedWords = renderedWords;

        for (int i = 0; i < wordCount; i++)
        {
            _whatIsHidden[i] = false;
        }
    }

    public void Display()
    {
        Console.Write(_reference + " " + _content);
    }

    public int GetWordListLength()
    {
        return _words.Length;
    }
    public void HideWords(int numberOfWordsToHide) 
    {
        bool completelyHidden = IsCompletelyHidden();

        if (completelyHidden == true)
        {
            Console.WriteLine("Thank you, good bye!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Do you see me?");
        }
    }

    public bool IsCompletelyHidden()
    {
        int wordCount = _words.Length;
        int count = 0;
        for (int i = 0; i < wordCount; i++)
        {
            if (_whatIsHidden[i] == true)
            {
                count++;
            }
        }

        if (count == wordCount)
        {
            return true;
        }
        else{
            return false;
        }
    }
}