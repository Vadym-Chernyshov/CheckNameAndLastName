namespace CheckNameAndLastName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Ви отримали рядок, який містить ім’я та прізвище користувача.
            // Ваша мета - перевірити, чи починається прізвище на ту ж літеру,
            // що й ім’я. Якщо так, вивести повідомлення
            // “Прізвище починається на ту ж літеру, що і ім’я”, інакше -
            // “Прізвище не починається на ту ж літеру, що і ім’я”.

            Console.WriteLine("Введіть ваше ім'я та прізвище");
            string userInput = Console.ReadLine();

            bool hasDigits = false;
            bool hasSpecialCharacters = false;            
            int countOfSpace = 0;
            sbyte indexOfFirstLetter = 0;

            string result = string.Empty;

            //перевірка на спец символи, цифри та кількості пробілів
            foreach (char symbol in userInput)
            {
                if (char.IsDigit(symbol)) hasDigits = true;
                if (!char.IsLetterOrDigit(symbol) && !char.IsWhiteSpace(symbol)) hasSpecialCharacters = true;
                if (symbol == ' ') countOfSpace++;               
            }

            if (!hasDigits && !hasSpecialCharacters && countOfSpace == 1)
            {
                string[] fullname = userInput.Split(' '); //робимо масив рядків
                //порівнюємо перші символи слів
                //вирішив дати можливість не залежати від регістру
                result = char.ToLower(fullname[0][indexOfFirstLetter]) 
                      == char.ToLower(fullname[1][indexOfFirstLetter])?
                      "Прізвище починається на ту ж літеру, що і ім’я" :
                      "Прізвище не починається на ту ж літеру, що і ім’я";
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Неправильний ввід. Спробуйте знову");
            }

        }
    }
}
