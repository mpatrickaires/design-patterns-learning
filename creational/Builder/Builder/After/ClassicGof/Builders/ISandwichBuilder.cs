namespace Builder.After.ClassicGof.Builders
{
    public interface ISandwichBuilder
    {
        void Reset();
        void SetBreadType(string breadType);
        void SetMainFilling(string mainFilling);
        void SetCheese(string cheese);
        void SetVegetables(List<string> vegetables);
        void SetSauce(string sauce);
    }
}
