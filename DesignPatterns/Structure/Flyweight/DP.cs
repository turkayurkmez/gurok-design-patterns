namespace Flyweight
{
    public class Planet
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Brush Color { get; set; }
        public Planet(Color color)
        {
            Color = new SolidBrush(color);
        }

        public void Draw(Graphics g)
        {

            g.FillEllipse(Color, X, Y, Radius, Radius);
        }
    }

    public static class PlanetFlyweight
    {
        //Problem: Bellekte çok fazla yer kaplayacak bir nesne koleksiyonunuz var. Buradaki maaliyeti en aza nasıl indirirsiniz?
        private static Dictionary<Color, Planet> planets = new Dictionary<Color, Planet>();
        public static Planet CreatePlanet(Color color)
        {
            if (!planets.ContainsKey(color))
            {
                Planet planet = new Planet(color);
                planets.Add(color, planet);
            }
            return planets[color];
        }
    }
}
