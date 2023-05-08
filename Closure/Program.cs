namespace Study
{
    public class Closure
    {
        static void Main()
        {
            int num = 0;

            Action[] action = new Action[5];
            for (int i = 0; i < 5; i++)
            {
                //일반 출력
                //Console.WriteLine(i);

                //람다식을 사용 -> 클로저 발생
                //action[i] = () => Console.WriteLine(i);

                //새로 선언되는 새로운 변수가 아니기 때문에 또 클로저 발생
                //num = i;
                //action[i] = () => Console.WriteLine(i);

                //for문이 돌때마다 test 변수가 새로 선언되기 때문에 클로저 해결
                int test = i;
                action[i] = () => Console.WriteLine(test);
            }

            for (int i = 0; i < 5; i++)
            {
                action[i]();
            }
        }
    }
}
