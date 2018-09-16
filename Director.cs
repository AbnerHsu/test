namespace Pattern
{
    public class Director
    {
        public void Constuct(IBuilder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }
    }
}