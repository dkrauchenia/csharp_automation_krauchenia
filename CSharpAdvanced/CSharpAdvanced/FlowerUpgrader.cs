namespace CSharpAdvanced
{
    public class FlowerUpgrader<T> where T : Flower
    {
        public void UpgradeFlower(T flower, string newColor)
        {
            flower.Color = newColor;
            flower.Price *= 1.15;
        }
    }
}
