namespace kursach.Services
{
    public class EncodingService
    {
        const string alphabetEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string alphabetRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public static string VigenereCipher(string text, string key, string language, string encryption)
        {
            string textUpper = text.ToUpper();

            string duplicatedKey = key;
            while (duplicatedKey.Length < text.Length)
            {
                duplicatedKey += key;
            }
            duplicatedKey = duplicatedKey.Substring(0, text.Length).ToUpper();

            string result = "";
            string defaultAlphabet = alphabetEng;
            if (language == "Русский")
            {
                defaultAlphabet = alphabetRus;
            }

            for (int i = 0; i < text.Length; i++)
            {
                int textIndex = defaultAlphabet.IndexOf(textUpper[i]);
                int duplicatedKeyIndex = defaultAlphabet.IndexOf(duplicatedKey[i]);
                
                if (textIndex < 0)
                {
                    result += text[i].ToString();
                    duplicatedKey = duplicatedKey.Insert(i, " ");
                }
                else
                {
                    if (char.IsLower(text[i]))
                    {
                        result += defaultAlphabet[(defaultAlphabet.Length + textIndex + (encryption == "encryption" ? 1 : -1) * duplicatedKeyIndex) % defaultAlphabet.Length].ToString().ToLower();
                    }
                    else
                    {
                        result += defaultAlphabet[(defaultAlphabet.Length + textIndex + (encryption == "encryption" ? 1 : -1) * duplicatedKeyIndex) % defaultAlphabet.Length].ToString();
                    }
                }
            }
            return result;
        }
    }
}
