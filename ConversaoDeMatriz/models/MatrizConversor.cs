class MatrizConversor
{
    public static void StringConversor(string Matriz){
        //X = 🟦
        //B = 🟫
        //Y = 🟨
        //G = 🟩
        //string replaceMatriz = Matriz.Replace("X", "🟦");
        //replaceMatriz = replaceMatriz.Replace("B", "🟫");
        //replaceMatriz = replaceMatriz.Replace("Y", "🟨");
        //replaceMatriz = replaceMatriz.Replace("G", "🟩");
        string replaceMatriz = Matriz.Replace("X", "🟦");
        replaceMatriz = replaceMatriz.Replace("B", "🟫");
        replaceMatriz = replaceMatriz.Replace("Y", "🟨");
        replaceMatriz = replaceMatriz.Replace("G", "🟩");
        
        System.Console.WriteLine(replaceMatriz);
    }
}