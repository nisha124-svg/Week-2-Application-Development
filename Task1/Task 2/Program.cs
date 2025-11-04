class Circle
{
    const double PI = 3.14;
    static void Main(string[] args)
    {
        PI = 1.28;  //! This line will generate a compile-time error because PI is a constant and cannot be reassigned.
    }
}