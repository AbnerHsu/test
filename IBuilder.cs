namespace Pattern
{
    public interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        
        Product GetProduct();
    }
}