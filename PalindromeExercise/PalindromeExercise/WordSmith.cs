namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        var reversed = "";
        var reversedArray = word.ToCharArray();
        
        for (int i = reversedArray.Length - 1; i >= 0; i--)
        {
            reversed += reversedArray[i];
        }
        
        return reversed == word;
    }
}