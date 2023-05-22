namespace Change_Character;
public static class Method
{
    private static string[] wordList;

    private static string getWords(){
        System.Console.Write("Please, enter words with spaces between them (Hello Turkey Istanbul): ");
        return Console.ReadLine().Trim();
    }

    private static bool spaceControl(string words){

        if(words == ""){
            System.Console.WriteLine("You didn't enter anything . Please, enter with a space between the two words...");
            return false;
        }


        for (int i = 0; i < words.Length; i++)
        {
            if(words[i] == ' ' && words[i+1] == ' '){
                System.Console.WriteLine("You have entered incorrectly. Please, enter with a space between the two words...");
                return false;
            }
        }
        wordList = words.Split(' ');
        return true;
    }

    public static void mainMethod()
    {
        Back:
        string words = getWords();
        if (spaceControl(words))
        {
            AlgoritmaMethod();
        }else{
            goto Back;
        }
    }

    private static void AlgoritmaMethod()
    {
        string newWord = "";

        foreach (var item in wordList)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if(i == 0){
                    newWord += item[item.Length-1];
                }else if(i==item.Length-1){
                    newWord += item[0];
                }else{
                    newWord += item[i];
                }
            }
            System.Console.Write(newWord + " ");
            newWord = "";
        }



    }
}
