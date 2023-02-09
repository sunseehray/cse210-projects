using System;
// this class saves a word that is hidden and renders it back as hidden text
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
    }
    
}
