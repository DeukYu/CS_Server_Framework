namespace TestCode
{
    class Program
    {
        delegate int OnClicked();
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        // 반환 : int 입력 : void
        // OnClicked 이 delegate 형식의 이름이다.
        static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘겨주고 */)
        {
            // 함수를 호출();
            clickedFunction();
        }
        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }
        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate2");
            return 0;
        }
        static void Main(string[] args)
        {
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;
            // delegate ( 대리자 )
            ButtonPressed(clicked/**/);
        }
    }
}