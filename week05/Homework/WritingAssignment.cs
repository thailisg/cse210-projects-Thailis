using System;

public class WritingAssignment : Assignment
{
    string _title;

    public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return GetSummary() + "\n" + _title;
    }
}   
