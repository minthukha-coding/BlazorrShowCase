namespace BlazorrShowCase.Components.Core
{
    public static class Responsive
    {
        public const int MobileMax = 767;
        public const int TabletMax = 1023;

        public static bool IsMobile(int width) => width <= MobileMax;
        public static bool IsTablet(int width) => width > MobileMax && width <= TabletMax;
        public static bool IsDesktop(int width) => width > TabletMax;
    }
}
