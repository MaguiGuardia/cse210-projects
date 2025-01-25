public class Scripture
{
    private string _text;
    private static List<Word> _words = new List<Word>();
        public Scripture(string text)
        {
            string[] words = text.Split("  ");
            foreach (string word in words)
            {
                
            }
        }
    

    public Scripture(string text)
    {
        _text = text;
    }


    public void HideRandomWords(int numberToHide)
    {
        
    }


    public string GetDisplayText()
    {
        string text =  $"{_text}";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}