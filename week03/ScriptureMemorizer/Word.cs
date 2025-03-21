
public class Word {
    private string _text;
    private bool _hidden;

    public Word(string text) {
        _text = text;
    }

    public void Hide() {
        _hidden = true;
    }

    public void Show() {
        _hidden = false;
    }

    public string GetDisplayText() {
        if (_hidden) {
            return "____";
        } else {
            return _text;
        }
    }

}