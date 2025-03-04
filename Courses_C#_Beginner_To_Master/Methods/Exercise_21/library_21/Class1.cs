public class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswerLetter = 'X';

    public Question() { correctAnswerLetter = defaultCorrectAnswerLetter; questionText = optionA = optionB = optionC = optionD = null; }
    //TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.


    public Question(string questionText) : this(questionText,null, null, null, null, defaultCorrectAnswerLetter)
    {
        //TO DO: Initialize questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        this.questionText = questionText;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;
        this.correctAnswerLetter = correctAnswerLetter;
    }


    public Question(string questionText, string optionA, string optionB, string optionC, string optionD) :
        this(questionText, optionA, optionB, optionC, optionD, defaultCorrectAnswerLetter)
    { }

    public bool AreOptionsValid()
    {
        //TO DO: Return true, if at least two options are not null
        if ((optionA != null && optionB != null) || (optionA != null && optionC != null) || (optionA != null && optionD != null) ||
            (optionC != null && optionB != null) || (optionD != null && optionB != null) || (optionC != null && optionD != null))
            return true;
        else return false;
    }
}
 