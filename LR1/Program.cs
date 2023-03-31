using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)//для консоли
    {
        string data ="привет";
        string key ="медвет";

        string encript = Encript(data,key);
        Console.WriteLine(encript);
        Console.WriteLine(Decrypt(encript, key));
    }
    private static string Encript(string input, string SecreKey)
    {
        List<char> data = input.ToCharArray().ToList();
        char[] key = SecreKey.ToCharArray();
        int index = 0;
        StringBuilder builder = new StringBuilder();
        for (int i = 0, j = 0; i < data.Count; i++, j++)
        {
            builder.Append(EncriptChart(key[index], data[i]));
            if(index == key.Length-1) j = 0;
        }
        return builder.ToString();
    }
    private static string Decrypt(string input, string SecreKey) 
    {
        List<char> data = input.ToCharArray().ToList();
        char[] key = SecreKey.ToCharArray();
        int index = 0;
        StringBuilder builder = new StringBuilder();
        for (int i = 0, j = 0; i < data.Count; i++, j++)
        {
            builder.Append(DecryptChar(key[index], data[i]));
            if (index == key.Length - 1) j = 0;
        }
        return builder.ToString();
    }
    private static char EncriptChart(char key, char input)// для шифрования   
    {
        return (char)(input + 1040 - key);
    }
    private static char DecryptChar(char key, char input)
    {
        return (char)(input - 1040 + key);
    }
}

//djBasBustWxdhs activated ПИУ ПИУ ПИУ Бразильский мальчик (phonk edition)....
//чат для переписки с подписчиками sava 5621
//нихуя не понимаю чо происходит, нахуй я пошел на программиста, мама я же грузчик.....
//день 2. Я смирился с бытием своей тупости, с программированием не пошло, хочу пойти в юристы
//день 3. Вроде стало понятнее, но желание пойти как Соня Мармеладова по желтому билету, не пропало
//день 4. Моя жизнь не будет прежней, он начал говорить про ЮнитКоды какие-то я в ахуе...
//день 5. Сейчас я въебашу сюда кота из символов
//день 6. Кот из символов, поехали



//1040 + key <1103
//1103



