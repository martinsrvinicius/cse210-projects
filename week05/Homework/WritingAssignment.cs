public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public WritingAssignment()
    {
    }

    public string GetWritingInformation()
    {
        return _title;
    }
}