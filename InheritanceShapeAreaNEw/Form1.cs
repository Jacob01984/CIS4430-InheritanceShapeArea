using System.Security.Cryptography.X509Certificates;

namespace InheritanceShapeAreaNEw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            Shape shape = new Shape();
            shape.height = Convert.ToDouble(numHeight.Value);
            
            txtOutput.Text = shape.displayHeight();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            square.height = Convert.ToDouble(numHeight.Value);
            txtOutput.Text = square.displayAreaSquare();

        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();

            triangle.height = Convert.ToDouble(numHeight.Value);
            triangle.bottom = Convert.ToDouble(numBase.Value);

            txtOutput.Text = triangle.displayAreaTriangle();
        }

        private void btnTrap_Click(object sender, EventArgs e)
        {
            Trapazoid trap = new Trapazoid();

            trap.height = Convert.ToDouble(numHeight.Value); 
            trap.bottom = Convert.ToDouble(numBase.Value);
            trap.side = Convert.ToDouble(numSide.Value);

            txtOutput.Text = trap.displayAreaTrapazoid();
        }
    }
}