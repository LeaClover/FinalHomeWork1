using finalHomeWorkGB;

namespace finalHomeWorkGB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Text text = new Text();
            text.MainText();
            text.TextToDo();
            string? str = Console.ReadLine();
            string[] array = str.Split(' ');
            Methods method = new Methods();
            method.PrintArray(method.GetArrayWhereStringLess3(array));
        }
    }

    class Methods
    {
        public string [] GetArrayWhereStringLess3(string[] array)
        {
            string[] arrayS = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                string str = array[i];
                int size = str.Length;
                if (size <= 3)
                {
                    arrayS[i] = array[i];
                }
            }
            return arrayS;
        }
        public void PrintArray(string [] arrayP)
        {
            for(int i = 0; i < arrayP.Length; i++)
            {
                Console.Write(arrayP[i] + " ");
            }
        }
    }
    class Text
    {
        public void MainText()
        {
            Console.WriteLine("Программа формирует массив строк, где количество символов меньше или равно трем!")
        }
        public void TextToDo()
        {
            Console.WriteLine("Введите текст через пробел и мы сформируем массив");
        }
    }
}