using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Point3D
{
    public static class PathStorage
    {
        public static void PathSave()
        {
            Path path = new Path();
            path.AddPoint();
            Point point = new Point(1, 2, 3);
            path.AddPoint(point);
            path.AddPoint(5, 6, 7);
            
            StreamWriter writer = new StreamWriter("newPath.txt");
            using (writer)
            {
                writer.WriteLine(path);

            }
        }
        public static void PathLoad()
        {
            Path path = new Path();
            StreamReader reader = new StreamReader("newPath.txt");
            using (reader)
            {
                StringBuilder line = new StringBuilder(reader.ReadLine());

                while (line.ToString()!="")
                {
                    
                    int [] array = line.ToString().Substring(11).Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    path.AddPoint(array[0], array[1], array[2]);
                    line = new StringBuilder(reader.ReadLine());
                }
               
            }
            Console.WriteLine(path.ToString());
        }
    }
}
