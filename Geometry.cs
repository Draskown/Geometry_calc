namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double ComputeArea(params double[] args){
            if (args.Length == 1){
                return ComputeCircleArea(args[0]);
            } else if (args.Length == 3){
                return ComputeCircleArea(args);
            } else

            Console.WriteLine("Not implemented yet");
            return 0.0;
        }

        public static double ComputeCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

       public static double ComputeTriangleArea(double[] sides)
        {
            double hypo = Math.Max(Math.Max(sides[0], sides[1]), sides[2]);
            double cat1 = Math.Min(Math.Min(sides[0], sides[1]), sides[2]);
            double cat2;
            
            if (cat1 == sides[0] && hypo == sides[1])
                cat2 = sides[2];
            else if (cat1 == sides[1] && hypo == sides[2]){
                cat2 = sides[0];
            } else
                cat2 = sides[1];

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