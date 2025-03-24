using FileManagement.Model;

namespace FileManagement;

internal class Program
{
    static void Main(string[] args)
    {
        DoubleLinkedList<char> charsList = new DoubleLinkedList<char>();
        int totalChars = 0;
        char ch;
        string filePath = @"C:\tmp\file.txt";
        int ordinal;
        GenericNode<char>? node;
        try
        {
            using StreamReader reader = new StreamReader(filePath);
            while ((ordinal = reader.Read()) != -1)
            {
                ch = (char)ordinal;
                if (Convert.ToInt32(ch) == 13 || Convert.ToInt32(ch) == 10)
                {
                    reader.Read();
                    continue;
                }

                node = charsList.GetPosition(ch);
                if (node == null)
                {
                    charsList.InsertLast(ch);
                }
                else
                {
                    charsList.IncreaseCount(node);
                }
                totalChars++;
            }
            charsList.ShortByCount();
            charsList.Traverse(totalChars);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

    }
}