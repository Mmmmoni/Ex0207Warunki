using System;

namespace Ex0207Warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam w zadaniach z tygodnia drugiego, lekcji siódmej.");
            Console.WriteLine("Zadanie 1.");

            int a = 5;
            int b = 5;

            string comparison = "comparison";

            comparison = (a == b) ? $"{a} i {b} są równe" : $"{a} i {b} są nierówne";

            Console.WriteLine (comparison);

            Console.WriteLine("");
            Console.WriteLine("Zadanie 2.");
            Console.WriteLine("Podaj liczbę całkowitą, sprawdzimy czy jest parzysta:");

            string choice = Console.ReadLine();

            int c = 0;
            Int32.TryParse(choice, out c);

            int wynik = c % 2;

            if (wynik != 0)
            {
                Console.WriteLine($"Liczba {c} jest nieparzysta");
            }
            else
            {
                Console.WriteLine($"Liczba {c} jest parzysta");
            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 3.");
            Console.WriteLine("Podaj liczbę, sprawdzimy czy jest dodatnia czy ujemna:");

            string choice2 = Console.ReadLine();

            double d = 0;
            Double.TryParse(choice2, out d);

            switch (d)
            {
                case > 0:
                    Console.WriteLine($"{d} jest liczbą dodatnią");
                    break;
                case < 0:
                    Console.WriteLine($"{d} jest liczbą ujemną");
                    break;
                default:
                    Console.WriteLine($"{d} ma wartość zerową");
                    break;

            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 4.");
            Console.WriteLine("Podaj rok, sprawdzimy czy jest przestępny:");

            string yearChoice = Console.ReadLine();

            int year = 0;
            Int32.TryParse(yearChoice, out year);

            if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
            {
                Console.WriteLine($"Rok {year} jest rokiem przestępnym");
            }
            else
            {
                if (year < 1582)
                {
                    Console.WriteLine($"Ups, w roku {year} nie obowiązywał kalendarz gregoriański");
                }
                if (year >= 1582)
                {
                    Console.WriteLine($"Rok {year} nie jest rokiem przestępnym");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 5.");
            Console.WriteLine("Podaj swój wiek:");

            string ageChoice = Console.ReadLine();

            int age = 0;
            Int32.TryParse(ageChoice, out age);

            if (age >= 21 && age < 30)
            {
                Console.WriteLine($"Wiek {age} uprawnia do kandydowania na stanowisko posła/premiera");
            }
            else if (age >= 21 && age < 35)
            {
                Console.WriteLine($"Wiek {age} uprawnia do kandydowania na stanowisko posła/premiera/senatora");
            }
            else if (age >= 35)
            {
                Console.WriteLine($"Wiek {age} uprawnia do kandydowania na stanowisko posła/premiera/senatora/prezydenta");
            }
            else if (age < 21)
            {
                Console.WriteLine($"Musisz jeszcze poczekać, aby ubiegać się o kandydature na posła/premiera/senatora/prezydenta.");
            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 6.");
            Console.WriteLine("Podaj swój wrost, w cm:");

            string heightChoice = Console.ReadLine();

            int height = 0;
            Int32.TryParse(heightChoice, out height);

            if (height >= 230)
            {
                Console.WriteLine($"{height}?! Na pewno jesteś Olbrzymem!");
            }
            else if (height >= 200)
            {
                Console.WriteLine($"{height}?! Ale z Ciebie Ogr!");
            }
            else if (height >= 170)
            {
                Console.WriteLine($"{height}? Uf, Człowiek.");
            }
            else if (height >= 165)
            {
                Console.WriteLine($"{height}? Uf, wciąż Człowiek, nie za wysoki.");
            }
            else if (height >= 160)
            {
                Console.WriteLine($"{height}? Cóż za uszy! To Elf!");
            }
            else if (height >= 140)
            {
                Console.WriteLine($"{height} Kransolud pełną gębą.");
            }
            else if (height >= 130)
            {
                Console.WriteLine($"{height} O, Hobbit do nas przywędrował.");
            }
            else if (height >= 100)
            {
                Console.WriteLine($"{height} Ledwo zauważalny, to Liliput");
            }
            else if (height < 100)
            {
                Console.WriteLine($"{height} To jeszcze Dziecko");
            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 7.");
            Console.WriteLine("Za chwilę podasz trzy liczby...");
            Console.WriteLine("Wpisz pierwszą liczbę:");

            string firstChoice = Console.ReadLine();

            int firstNumber = 0;
            Int32.TryParse(firstChoice, out firstNumber);

            Console.WriteLine("Wpisz drugą liczbę:");

            string secondChoice = Console.ReadLine();

            int secondNumber = 0;
            Int32.TryParse(secondChoice, out secondNumber);

            Console.WriteLine("Wpisz trzecią liczbę:");

            string thirdChoice = Console.ReadLine();

            int thirdNumber = 0;
            Int32.TryParse(thirdChoice, out thirdNumber);

            if ((firstNumber >= secondNumber) && (firstNumber >= thirdNumber))
            {
                Console.WriteLine($"Najwięszka z wpisanych liczb to:{firstNumber}");
            }
            else if (secondNumber >= thirdNumber)
            {
                Console.WriteLine($"Najwięszka z wpisanych liczb to:{secondNumber}");
            }
            else if (thirdNumber >= secondNumber)
            {
                Console.WriteLine($"Najwięszka z wpisanych liczb to:{thirdNumber}");
            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 8.");
            Console.WriteLine("Wpisz punkty otrzymane na maturze z Matematyki:");

            string mathResult = Console.ReadLine();
            int mathPoints = 0;
            Int32.TryParse(mathResult, out mathPoints);

            Console.WriteLine("Wpisz punkty otrzymane na maturze z Fizyki:");

            string physicsResult = Console.ReadLine();
            int physicsPoints = 0;
            Int32.TryParse(physicsResult, out physicsPoints);

            Console.WriteLine("Wpisz punkty otrzymane na maturze z Chemii:");

            string chemistryResult = Console.ReadLine();
            int chemistryPoints = 0;
            Int32.TryParse(chemistryResult, out chemistryPoints);

            int totalPoints = mathPoints + physicsPoints + chemistryPoints;

            if (mathPoints > 70 && physicsPoints > 55 && chemistryPoints > 45 && totalPoints > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else if ((mathPoints + physicsPoints) > 150 || (mathPoints + chemistryPoints) > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji.");
            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 9.");
            Console.WriteLine("Podaj temperature:");

            string tempChoice = Console.ReadLine();

            double temp = 0;
            Double.TryParse(tempChoice, out temp);

            switch (temp)
            {
                case < 0:
                    Console.WriteLine("Cholernie... mrozi.");
                    break;
                case < 10:
                    Console.WriteLine("Zimno.");
                    break;
                case < 20:
                    Console.WriteLine("Chłodno.");
                    break;
                case < 30:
                    Console.WriteLine("W sam raz.");
                    break;
                case < 40:
                    Console.WriteLine("Zaczyna być słabo, bo gorąco.");
                    break;
                case >= 40:
                    Console.WriteLine("A weź, wyprowadzam się na Alaskę.");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Zadanie 10.");
            Console.WriteLine("Podaj pierwszy bok trójkąta:");

            string sideAChoice = Console.ReadLine();

            int sideA = 0;
            Int32.TryParse(sideAChoice, out sideA);

            Console.WriteLine("Podaj drugi bok trójkąta:");

            string sideBChoice = Console.ReadLine();

            int sideB = 0;
            Int32.TryParse(sideBChoice, out sideB);

            Console.WriteLine("Podaj trzeci bok trójkąta:");

            string sideCChoice = Console.ReadLine();

            int sideC = 0;
            Int32.TryParse(sideCChoice, out sideC);

            if (((sideA+sideB)>sideC)&& ((sideA + sideC) > sideB)&& ((sideC + sideB) > sideA))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
            Console.WriteLine("");
            Console.WriteLine("Zadanie 11.");
            Console.WriteLine("Podaj ocene:");

            string gradeChoice = Console.ReadLine();
            int gradeNumber = 0;
            Int32.TryParse(gradeChoice, out gradeNumber);

            string gradeString = gradeNumber switch
            {
                1=>"Niedostateczny",
                2=>"Dopuszczalny",
                3=>"Dostateczny",
                4=>"Dobry",
                5=>"Bardzo dobry",
                6=>"Celujący",
                _=>"Nie ma takiej oceny"
            };
            Console.WriteLine($"{gradeString}");

            Console.WriteLine("");
            Console.WriteLine("Zadanie 12.");
            Console.WriteLine("Podaj numer dnia tygodnia:");

            string dayChoice = Console.ReadLine();

            int day = 0;
            Int32.TryParse(dayChoice, out day);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default: 
                    Console.WriteLine("Na naszej planecie nie mamy takiego dnia tygodnia");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Zadanie 13.");
            Console.WriteLine("Podaj pierwszą liczbę:");

            string numberOneChoice = Console.ReadLine();

            decimal numberOne = 0;
            Decimal.TryParse(numberOneChoice, out numberOne);

            Console.WriteLine("Podaj drugą liczbę:");

            string numberTwoChoice = Console.ReadLine();

            decimal numberTwo = 0;
            Decimal.TryParse(numberTwoChoice, out numberTwo);

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            string mathFunctionChoice = Console.ReadLine();

            int mathFunction = 0;
            Int32.TryParse(mathFunctionChoice, out mathFunction);

            switch (mathFunction)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to: {numberOne + numberTwo}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to: {numberOne - numberTwo}");
                    break;
                case 3:
                    Console.WriteLine($"Twój wynik to: {numberOne * numberTwo}");
                    break;
                case 4:
                    if (numberTwo != 0)
                    { 
                        Console.WriteLine($"Twój wynik to: {numberOne / numberTwo}"); 
                    }
                    else
                    {
                        Console.WriteLine("Pamiętaj Cholero, nie dziel przez zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Błąd! Tak nie działamy.");
                    break;
            }

        }
    }
}