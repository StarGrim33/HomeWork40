
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя: ");

            string mageName = Console .ReadLine();
            string bossName = "Гаррош";
            int mageHp = 1400;

            int fireBall = 200;
            int magmaStack = 0;
            int magmaAttack = 350;
            int magmaFirstAid = 200;
            int magmaBlast = 400;
            int magmaStackMagmaAttack = 2;
            int magmaStackFirstAid = 3;
            int magmaStackMagmaBlast = 5;

            int bossHp = 2000;

            int userInput;

            Console.Clear();
            Console.SetCursorPosition(2,2);
            Console.WriteLine(" Для использования заклинания Magma Attack требуется накопить два очка магмы, каждый удар Fire Ball дает одно очко!");
            Console.WriteLine(" Для использования заклинания Magma First Aid требуется накопить три очка магмы.");
            Console.WriteLine(" Для использования заклинания Magma Blast требуется накопить пять очков магмы.");
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("\nБой на арене начинается ! Схватка между " + mageName + " и " + bossName);

          

            while (mageHp > 0 && bossHp > 0)
            {
                Random random = new Random();
                int bossDamage = random.Next(100, 200);
                Console.WriteLine("Выберите заклинание для аттаки:");
                Console.WriteLine("1 - Fire Ball: " + fireBall + " damage");
                Console.WriteLine("2 - Magma Attack: " + magmaAttack + " damage. Для этого заклинания требуется " + magmaStackMagmaAttack + " очков магмы");
                Console.WriteLine("3 - Magma First Aid: восстанавливает " + magmaFirstAid + " очков здоровья");
                Console.WriteLine("4 - Magma Blast: " + magmaBlast + " damage");

                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1: 
                        if (userInput == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(mageName + " атакует " + bossName + " с помощью Fire Ball " + " и наносит " + fireBall + " урона");
                            bossHp -= fireBall;
                            magmaStack += 1;
                            Console.WriteLine(bossName + " атакует в ответ и наносит " + mageName + " " + bossDamage + " урона !");
                            mageHp -= bossDamage;
                            Console.WriteLine("Уровень здоровья оппонентов " + mageName + " = " + mageHp + " " + bossName + " = " + bossHp);
                            Console.WriteLine("Количество очков магмы у " + mageName + ": " + magmaStack);
                        }
                        break;
                    case 2: 
                        if (userInput == 2 && magmaStack == magmaStackMagmaAttack)
                        {
                            Console.Clear();
                            Console.WriteLine(mageName + " атакует " + bossName + " Magma Attack ");
                            bossHp -= magmaAttack;
                            magmaStack -= 2;
                            Console.WriteLine("У " + bossName + " осталось " + bossHp + " здоровья");
                            Console.WriteLine(bossName + " атакует в ответ и наносит " + mageName + " " + bossDamage + " урона !");
                            mageHp -= bossDamage;
                            Console.WriteLine("Уровень здоровья оппонентов " + mageName + " = " + mageHp + " , стаков магмы " + magmaStack + " " + bossName + " = " + bossHp);
                        }
                        else
                        {
                            Console.WriteLine("У Вас недостаточно стаков магмы");
                        }
                        break;
                    case 3:
                        if (userInput == 3 && magmaStack == magmaStackFirstAid)
                        {
                            Console.Clear();
                            Console.WriteLine(mageName + " восстанавливает себе " + magmaFirstAid + " очков здоровья");
                            mageHp += magmaFirstAid;
                            magmaStack -= 3;
                            Console.WriteLine("Уровень здоровья оппонентов " + mageName + " = " + mageHp + " , стаков магмы " + magmaStack + " " + bossName + " = " + bossHp);
                        }
                        else
                        {
                            Console.WriteLine("У Вас недостаточно стаков магмы");
                        }
                        break;
                    case 4:
                        if (userInput == 4 && magmaStack == magmaStackMagmaBlast)
                        {
                            Console.Clear();
                            Console.WriteLine(mageName + " атакует " + bossName + " Magma Blast");
                            bossHp -= magmaBlast;
                            magmaStack -= 5;
                            Console.WriteLine("У " + bossName + " осталось " + bossHp + " здоровья");
                            Console.WriteLine(bossName + " атакует в ответ и наносит " + mageName + " " + bossDamage + " урона !");
                            mageHp -= bossDamage;
                            Console.WriteLine("Уровень здоровья оппонентов " + mageName + " = " + mageHp + " , стаков магмы " + magmaStack + " " + bossName + " = " + bossHp);
                        }
                        else
                        {
                            Console.WriteLine("У Вас недостаточно стаков магмы");
                        }
                        break;
                }
                if (mageHp <= 0)
                {
                    Console.WriteLine("Гаррош победил!");
                }
                else if (mageHp <= 0 && bossHp <= 0)
                {
                    Console.WriteLine("Ничья!");
                }
                else if (bossHp <= 0)
                {
                    Console.WriteLine(mageName + " победил!");
                }
            }
        }
    }
}