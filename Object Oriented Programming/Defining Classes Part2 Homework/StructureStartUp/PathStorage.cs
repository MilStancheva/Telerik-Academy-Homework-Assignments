//Problem 4. Path
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

namespace EuclideanSpace
{
    using System.IO;
    using Models;

    public static class PathStorage
    {

        public static void SavePath(Models.Path path, string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                foreach (var point in path)
                {
                    sw.WriteLine(point);
                }
            }
        }

        private static Models.Path GetPath(Models.Path path)
        {
            return path;
        }

        public static Models.Path LoadPath(string filePath)
        {
            var path = new Models.Path();
            var sr = new StreamReader(filePath);

            using (sr)
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Point3D point = Point3D.Parse(line);
                    path.AddPoint(point);
                } 
            }
            return path;
        }
    }
}
