namespace OPP_Showcase
{

    public class Fruit
    {
        public string taste;
        public float size = 1;

        public bool eat(int bites)
        {
            for (int bite in bites) {
                Console.WriteLine(bite);
                size -= 1 / (float) bites; 
            }
            return true;
        }
    }

    public class Apple : Fruit
    {
        public enum TYPES
        {
            GRANNY_SMITH    = 0x00,
            RED_DELICIOUS   = 0xFF  // 1111 1111 (16 × 16^1) + (16 × 16^0) | 15×16=240 + 15 | 0 1 2 3 4 5 6 7 8 9 A (10) B (11) C (12) D (13) E (14) F (15)
                                    // (1 × 2^7) + (1 × 2^6) + (1 × 2^5) + (1 × 2^4) + (1 × 2^3) + (1 × 2^2) + (1 × 2^1) + (1 × 2^0)
        }
        int age; // member variable
        Apple.TYPES type;

        public static void callApple()
        {
            Console.WriteLine("Hello this is apple support.");
        }

        public Apple(int inAge, Apple.TYPES inType, string inTaste)
        {

            age = inAge;
            type = inType;
            taste = inTaste;
        }

        public int prt() // ptr = print
        {
            Console.Write(age); // vypsání
            return age; // vrácení
        }

        public bool eat(int bites)
        {
            return false;
        }
    }

}


