using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public void SetWord(string word, bool isHidden = true)
    {
        _word = word;
        _isHidden = isHidden;
    }

    public string GetRenderedText()
    {
        int len = _word.Length;
        string renderedWord = "";
        for(int i = 0; i < len; i++)
        {
            renderedWord += "_";
        }
        return renderedWord;
        // string[] characters;
        // characters = _word.Split();
        // string finalWord = "";
        // for (int i = 0; i < characters.Length; i++)
        // {
        //     if (_isHidden == true)
        //     {
        //         characters[i] = "_";
        //     }
        //     else
        //     {
        //         characters[i] = characters[i];
        //     }
        //     finalWord += characters[i];
        // }
        // return finalWord;
    }
    
}
