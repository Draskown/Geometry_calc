namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double ComputeCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

       public static double ComputeTriangleArea(double sideA, double sideB, double sideC)
        {
            double hypo = Math.Max(Math.Max(sideA, sideB), sideC);
            double cat1 = Math.Min(Math.Min(sideA, sideB), sideC);
            double cat2;
            
            if (cat1 == sideA && hypo == sideB)
                cat2 = sideC;
            else if (cat1 == sideB && hypo == sideC){
                cat2 = sideA;
            } else
                cat2 = sideB;

            if (cat1 + cat2 <= hypo){
                Console.WriteLine("Invalid sides!");

                return 0.0;
            }

            if (hypo*hypo == (cat1*cat1 + cat2*cat2)){
                Console.WriteLine("Right Triangle");
                return 0.5 * cat1 * cat2;
            }
            else {
                double s = (hypo + cat1 + cat2) / 2.0;
                double area = Math.Sqrt(s * (s - hypo) * (s - cat1) * (s - cat2));
                return area;
            }
        }
    }
}