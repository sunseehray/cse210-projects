using System;

public class Scripture
{
    private string _reference;
    private string _content;
    private string[] _words;
    private bool[] _whatIsHidden;
    private string[] _renderedWords;
    private int _numberOfHiddenWords;

    // default is single verse
    public Scripture()
    {
        Reference reference = new Reference();
        _reference = reference.GetReference(reference);
        _content = reference.GetScripture(reference);
        _numberOfHiddenWords = 0;
        CreateArrays(_content);
    }

    // for multiple verse
    public Scripture(int i = 2)
    {
        Reference reference1 = new Reference();
        Reference reference2 = new Reference(2);
        _reference = reference1.GetMultiReference(reference1, reference2);
        _content = reference1.GetMultiScripture(reference1,reference2);
        _numberOfHiddenWords = 0;
        CreateArrays(_content);
    }
    public void CreateArrays(string source)
    {
        _words = source.Split();
        int wordCount = _words.Length;
        bool[] whatIsHidden = new bool[wordCount];
        _whatIsHidden = whatIsHidden;
        _renderedWords = _words;

        // instantiate the _whatIsHidden array with false values, meaning all words are shown
        for (int i = 0; i < wordCount; i++)
        {
            _whatIsHidden[i] = false;
        }
    }

    // for checking if the code works
    public void Display()
    {
        Console.Write(_reference + " " + _content);
    }

    public int GetWordListLength()
    {
        return _words.Length;
    }

    public string GetRenderedText()
    {
        string renderedText = "";

        foreach(string element in _renderedWords)
        {
            renderedText += element + " ";
        }

        return renderedText;
    }
    public void HideWords(int numberOfWordsToHide) 
    {
        int wordCount = GetWordListLength();

        bool completelyHidden = IsCompletelyHidden();

        if (completelyHidden == true)
        {
            // end the program if all words are hidden
            Console.WriteLine(_reference + " " + GetRenderedText());
            Console.WriteLine();
            Console.WriteLine("Thank you, good bye!");
            Environment.Exit(0);
        }
        else
        {
            while (_numberOfHiddenWords < numberOfWordsToHide)
            {
                // track if a word was changed to hidden
                int didChange = 0;

                // find a random word that is available to hide
                while (didChange == 0)
                {
                    Random random = new Random();
                    int index = random.Next(0, wordCount);

                    /* if the randomly selected word is not yet hidden, hide it, 
                    otherwise, find another word until something gets changed to hidden */
                    if (_whatIsHidden[index] == false)
                    {
                        _whatIsHidden[index] = true;
                        // track that a word was changed
                        didChange = 1;

                        // use the Word GetRenderedText behavior to set the rendered text of the hidden word
                        Word hiddenWord = new Word();
                        hiddenWord.SetWord(_words[index]);

                        string renderedWord = hiddenWord.GetRenderedText();
                        // update the rendering of the word from the _renderedWords array
                        _renderedWords[index] = renderedWord;

                        _numberOfHiddenWords++;
                    }
                }
            }
            Console.WriteLine(_reference + " " + GetRenderedText());
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
        else
        {
            return false;
        }
    }
}