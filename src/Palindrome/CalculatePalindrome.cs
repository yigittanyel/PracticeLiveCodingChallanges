namespace Palindrome;

internal class CalculatePalindrome
{
    internal bool IsPalindrome(string word)
    {
        int min = 0; //başlangıç indexi
        int max = word.Length - 1; //bitiş indexi

        while (true) 
        {
            if (min > max) //demek ki bütün karakterler kontrol edilmiş
            {
                return true;
            }

            char a = word[min]; //başlangıç indexindeki karakteri a değişkenine ata
            char b = word[max]; //bitiş indexindeki karakteri b değişkenine ata

            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }

            //bir sonraki karaktere geçip onu kontrol etme kısmı için
            min++;
            max--;
        }
    }   
}
