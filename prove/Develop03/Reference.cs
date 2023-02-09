using System;

// build References of up to two verses only - limit
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseNum;
    private string _text;

    private string _proverbs_3_5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
    private string _proverbs_3_6 = "In all thy ways acknowledge him, and he shall direct thy paths.";

    // construct default scripture
    public Reference()
    {
        _book = "Proverbs";
        _chapter = 3;
        _verseNum = 5;
        _text = _proverbs_3_5;
    }
    // allow up to two verses assuming they are consecutive
    public Reference(int i = 2)
    {
        _book = "Proverbs";
        _chapter = 3;
        _verseNum = 6;
        _text = _proverbs_3_6;
    }
    // allow user to build own scripture references in the future
    public Reference(string book, int chapter, int verseNum, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseNum = verseNum;
        _text = text;
    }
    public string GetReference (Reference reference)
    {
        return reference._book + " " + reference._chapter + ":" + reference._verseNum;
    }

    public string GetScripture (Reference reference)
    {
        return reference._text;
    }

    public string GetMultiReference (Reference reference1, Reference reference2)
    {
        return reference1._book + " " + reference1._chapter + ":" + reference1._verseNum + "-" + reference2._verseNum;
    }

    public string GetMultiScripture (Reference reference1, Reference reference2)
    {
        return reference1._text + " " + reference2._text;
    }
}