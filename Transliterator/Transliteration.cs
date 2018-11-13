using System.Text;


namespace Transliterator
{
    class Transliteration
    {
        private StringBuilder text;
        public string TransliterateText
        {
            get
            {
                return text.ToString();
            }
            set
            {
                text = new StringBuilder(value);
            }
        }
        public void Transliterate()
        {
            UpperCaseTransliteration(text);
            LowerCaseTransliteration(text);
        }
        private static void UpperCaseTransliteration(StringBuilder text)
        {
            text.Replace("А", "A");
            text.Replace("Б", "B");
            text.Replace("В", "V");
            text.Replace("Г", "G");
            text.Replace("Д", "D");
            text.Replace("Е", "E");
            text.Replace("Ё", "E");
            text.Replace("Ж", "J");
            text.Replace("З", "Z");
            text.Replace("И", "I");
            text.Replace("Й", "I");
            text.Replace("К", "K");
            text.Replace("Л", "L");
            text.Replace("М", "M");
            text.Replace("Н", "N");
            text.Replace("О", "O");
            text.Replace("П", "P");
            text.Replace("Р", "R");
            text.Replace("С", "S");
            text.Replace("Т", "T");
            text.Replace("У", "U");
            text.Replace("Ф", "F");
            text.Replace("Х", "H");
            text.Replace("Ц", "C");
            text.Replace("Ч", "Ch");
            text.Replace("Ш", "Sh");
            text.Replace("Щ", "Sc");
            text.Replace("Ъ", "");
            text.Replace("Ы", "Y");
            text.Replace("Ь", "");
            text.Replace("Э", "E");
            text.Replace("Ю", "Iu");
            text.Replace("Я", "Ia");
        }
        private static void LowerCaseTransliteration(StringBuilder text)
        {
            text.Replace("а", "a");
            text.Replace("б", "b");
            text.Replace("в", "v");
            text.Replace("г", "g");
            text.Replace("д", "d");
            text.Replace("е", "e");
            text.Replace("ё", "e");
            text.Replace("ж", "j");
            text.Replace("з", "z");
            text.Replace("и", "i");
            text.Replace("й", "i");
            text.Replace("к", "k");
            text.Replace("л", "l");
            text.Replace("м", "m");
            text.Replace("н", "n");
            text.Replace("о", "o");
            text.Replace("п", "p");
            text.Replace("р", "r");
            text.Replace("с", "s");
            text.Replace("т", "t");
            text.Replace("у", "u");
            text.Replace("ф", "f");
            text.Replace("х", "h");
            text.Replace("ц", "c");
            text.Replace("ч", "ch");
            text.Replace("ш", "sh");
            text.Replace("щ", "sc");
            text.Replace("ъ", "");
            text.Replace("ы", "y");
            text.Replace("ь", "");
            text.Replace("э", "e");
            text.Replace("ю", "iu");
            text.Replace("я", "ia");
        }
    }
}