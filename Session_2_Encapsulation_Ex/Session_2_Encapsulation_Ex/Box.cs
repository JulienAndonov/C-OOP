using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P01_Box
{
    public class Box
    {




        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double LatheralSurfaceArea()
        {
            var latheralSurfaceArea = (2 * length * height) + (2 * width * height);
            return latheralSurfaceArea;
        }

        public double SurfaceArea()
        {
            var surfaceArea = (2 * length * width) + (2 * length * height) + (2 * width * height);

            return surfaceArea;
        }


        public double Volume()
        {
            var volume = length * height * width;
            return volume;
        }

        public override string ToString()
        {
            StringBuilder boxAreas = new StringBuilder();
            boxAreas.AppendLine($"Surface Area - {this.SurfaceArea():F2}");
            boxAreas.AppendLine($"Lateral Surface Area - {this.LatheralSurfaceArea():F2}");
            boxAreas.Append($"Volume - {this.Volume():F2}");
            return boxAreas.ToString();
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.Width;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException($"Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }


        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException($"Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        private double length;
        private double width;
        private double height;
    }
}
