// Программа, которая принимает на вход номер четверти
// и выдает диапазон координат, доступных в этой четверти

void NomerChetverti(int numChetvert)
{
    switch(numChetvert)
    {
        case 1:
        {
            Console.WriteLine("Можно ввести х > 0 и у > 0");
            break;
        }
        case 2:
        {
            Console.WriteLine("Можно ввести х < 0 и у > 0");
            break;
        }
        case 3:
        {
            Console.WriteLine("Можно ввести х < 0 и у < 0");
            break;
        }
        case 4:
        {
            Console.WriteLine("Можно ввести х > 0 и у < 0");
            break;
        }
        default:
        {
            Console.WriteLine("Не пиши ерунды");
            break;
        }


    }    
    
}

Console.WriteLine("Введите номер четверти");
int Chetvert = Convert.ToInt32(Console.ReadLine());
NomerChetverti(Chetvert);

