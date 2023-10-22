public class Reference
{
    private string _book = "John";
    private int _chapter = 3;
    private List<int> _verseNumber = new List<int>(new int[] { 16 });
    
    private string _reference;

    public string GetReference()
    {
        _reference = _book + " " + _chapter + ":";

        if (_verseNumber.Count > 1)
        {
            _reference += _verseNumber[0] + "-" + _verseNumber[_verseNumber.Count - 1] + " ";
        }
        else
        {
            _reference += _verseNumber[0] + " ";
        }

        return _reference;
    }
}