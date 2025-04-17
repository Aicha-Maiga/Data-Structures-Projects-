// Written by Aicha Maiga 
// 04/16/2025



namespace HW8ValidParentheses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ValidParentheses aValidParentheses = new ValidParentheses();

            Console.WriteLine(aValidParentheses.IsValid("()"));       
            Console.WriteLine(aValidParentheses.IsValid("()[]{}"));   
            Console.WriteLine(aValidParentheses.IsValid("(]"));       
            Console.WriteLine(aValidParentheses.IsValid("([])"));     
            Console.WriteLine(aValidParentheses.IsValid("["));        
            Console.WriteLine(aValidParentheses.IsValid("((()))"));   
            Console.WriteLine(aValidParentheses.IsValid("({[)]}"));   
        }
    }
}
